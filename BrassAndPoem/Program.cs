using System;
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new()
{


        new Product()
        {
            Name = "Trumpet",
            ProductTypeId = 1,
            Price = 14.88m
        },
        new Product()
        {
            Name = "The Road Not Taken",
            ProductTypeId = 2,
            Price = 3.99m
        },
        new Product()
        {
            Name = "Cornet",
            ProductTypeId = 1,
            Price = 24.99m
        },
        new Product()
        {
            Name = "Fire and Ice",
            ProductTypeId = 2,
            Price = 10.05m
        },
        new Product()
        {
            Name = "French Horn",
            ProductTypeId = 1,
            Price = 9.99m
        }

};
//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

List<ProductType> productType = new() {

    new ProductType()
    {
        Title = "Brass",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2
    }
};

//put your greeting here
string greeting = "Welcome to Brass and Poem!";
Console.WriteLine(greeting);

//implement your loop here
string choice = null;
while (choice != "5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            DisplayAllProducts(products, productType);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            DeleteProduct(products, productType);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            AddProduct(products, productType);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            UpdateProduct(products, productType);
            Console.WriteLine("Press any key to conetinue.");
            Console.ReadKey();
            Console.Clear();
            break;
        case "5":
            Console.WriteLine("Goodbye");
            break;
    }
}

void DisplayMenu()
{
    Console.WriteLine(@"
    1. Display all products
    2. Delete a product
    3. Add a new product
    4. Update product properties
    5. Exit");

}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    if (products.Count == 0)
    {
        Console.WriteLine("No products available.");
        return;
    }

    Console.WriteLine("All Products:");
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType productType = productTypes.FirstOrDefault(prodType => prodType.Id == product.ProductTypeId);
        if (productType != null)
        {
            int index = i + 1;
            Console.WriteLine($"{index}. Price: {product.Price:C} \t Title: {productType.Title} \t Product Name: {product.Name}");
        }
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Please select the number of the product you would like to remove.");
    DisplayAllProducts(products, productTypes);
    if (Int32.TryParse(Console.ReadLine(), out int response) && response > 0 && response <= products.Count)
    {
        int adjustedResponse = response - 1;
        products.RemoveAt(adjustedResponse);
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the name of the product you would like to add: ");
    string newProductName = Console.ReadLine();
    if (String.IsNullOrEmpty(newProductName))
    {
        Console.WriteLine("Product name can not be empty. Try again.");
        return;
    }

    Console.WriteLine("Please enter the price of the new product: ");
    if(!Decimal.TryParse(Console.ReadLine(), out decimal price))
    {
        Console.WriteLine("Invalid price format. Must be in decimal form. Product will not be added.");
        return;
    }

    Console.WriteLine("Please choose a number for which product type ID this new product belongs to: ");
    
        for(int i = 0; i < productTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Product type ID: {productTypes[i].Id} \t {productTypes[i].Title}");
        }
    
    if(!Int32.TryParse(Console.ReadLine(), out int productTypeId) || productTypeId < 1 || productTypeId > productTypes.Count)
    {
        Console.WriteLine("Invalid product type ID. This product will not be added.");
        return;
    }

    Product newProduct = new()
    {
        Name = newProductName,
        Price = price,
        ProductTypeId = productTypeId
    };
    products.Add(newProduct);

    Console.WriteLine("Product added successfully!");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the number for the product you wish to update: ");
    DisplayAllProducts(products, productTypes);

    if (Int32.TryParse(Console.ReadLine(), out int productIndex) && productIndex >= 1 && productIndex <= products.Count)
    {
        int adjustedIndex = productIndex - 1;
        Product productToUpdate = products[adjustedIndex];

        Console.WriteLine("Enter the updated name of the product (press enter to leave the name unchanged).");
        string updatedName = Console.ReadLine();
        if (!String.IsNullOrEmpty(updatedName))
        {
            productToUpdate.Name = updatedName;
        }

        Console.WriteLine("Enter the updated price of the product (press enter to leave the price unchanged).");
        string updatedPriceInput = Console.ReadLine();
        if (!String.IsNullOrEmpty(updatedPriceInput) && Decimal.TryParse(updatedPriceInput, out decimal updatedPrice))
        {
            productToUpdate.Price = updatedPrice;
        }

        Console.WriteLine("Enter the updated product type ID (press enter to leave unchanged).");
        for (int i = 0; i < productTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Product ID: {productTypes[i].Id} \t Product Title: {productTypes[i].Title}");
        }

        string updatedProductType = Console.ReadLine();
        if (!String.IsNullOrEmpty(updatedProductType) && Int32.TryParse(updatedProductType, out int updatedId) && updatedId >= 1 && updatedId <= productTypes.Count)
        {
            productToUpdate.ProductTypeId = updatedId;
        }

        Console.WriteLine("Prudct updated!");
    }
    else
    {
        Console.WriteLine("Invalid product. Update canceled.");
    }
 
}

// don't move or change this!
public partial class Program { }