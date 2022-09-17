
using AssetTracking;

Console.WriteLine("Hello and welcome to Asset Tracking!");//introduction
Console.WriteLine("We are researching which products these three offices has sold the most.");
Console.WriteLine("San Francisco, USA. Copenhagen, Denmark. Sibiu, Romania.");
Console.WriteLine("If you have bought anything from these offices, we have some questions.");
Console.WriteLine("Let's start!");

List<Product> products = new List<Product>();
//list for the products


bool addProduct = true;
while (addProduct)
//will allow the user to input as much product as they want
{

    Console.WriteLine("Type of product: ");
    string typeOfProduct = Console.ReadLine();

    Console.WriteLine("What brand is the product: ");
    string productBrand = Console.ReadLine();

    Console.WriteLine("And what model is it: ");
    string productModel = Console.ReadLine();

    Console.WriteLine("From what office is this product bought: ");
    string office = Console.ReadLine();

    Console.WriteLine("When did you buy this product: ");
    string purchaseDate = Console.ReadLine();
    DateOnly dateOfPurchase = DateOnly.Parse(purchaseDate);

    Console.WriteLine("How much did you pay for the product, in $: ");
    string priceInput = Console.ReadLine();
    float price = 0;
    price = float.Parse(priceInput);

    Product p = new Product(typeOfProduct, productBrand, productModel, dateOfPurchase, price, office);
    products.Add(p);


    Console.WriteLine("If you would like to add more product, type 'Y'");
    string addMore = Console.ReadLine();
    if (addMore.ToUpper().Trim() != "Y")
    {
        addProduct = false;
    }
    //asking user if theyd like to input more information



}

List<Product> sortedProducts = new List<Product>();
sortedProducts = products.OrderBy(product => product.getSortedProductType()).ThenBy(product => product.office).ThenBy(product => product.purchaseDate).ToList();
//sorting the product 

foreach (Product prod in sortedProducts)
{
    if (prod.purchaseDate <= DateOnly.FromDateTime(DateTime.Now).AddYears(-3).AddMonths(3) && prod.purchaseDate > DateOnly.FromDateTime(DateTime.Now).AddYears(-3))
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
    // telling the console to have a specific color if the date of purchase is after 2 years and 9 months

    Console.WriteLine("Product:  \n " + prod.productType);
    Console.WriteLine("Here is the date you purchase the product:\n  " + prod.purchaseDate);
    Console.WriteLine("Here is your product brand:\n  " + prod.productbrand);
    Console.WriteLine("Here is your product model:\n  " + prod.productmodel);
    Console.WriteLine("Here is where you bought your product:\n  " + prod.office);
    Console.WriteLine("Here is the price you paid:\n  " + prod.price);
   //outputting the product
}
Console.ReadKey();
