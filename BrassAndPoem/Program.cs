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
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }