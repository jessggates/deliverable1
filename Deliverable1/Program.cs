{
    Console.WriteLine("Welcome to the restocking tool.");

}

int sodaStock = 100;
int chipsStock = 40;
int candyStock = 60;

{
    Console.WriteLine("How many Sodas have been sold today? 100 are in stock.");
    int sodaSold = int.Parse(Console.ReadLine());
    if (sodaSold > sodaStock)
    {
        Console.WriteLine("That value is too high. Stock not adjusted.");
    }
    else if (sodaSold <= sodaStock)
    {
        sodaStock = sodaStock - sodaSold;
        Console.WriteLine("There are " + sodaStock + " sodas left in stock.");
    }

}
{
    Console.WriteLine("How many Chips have been sold today? 40 are in stock.");
    int chipsSold = int.Parse(Console.ReadLine());
    if (chipsSold > chipsStock)
    {
        Console.WriteLine("That value is too high. Stock not adjusted.");
    }
    else if (chipsSold <= chipsStock)
    {
        chipsStock = chipsStock - chipsSold;
        Console.WriteLine("There are " + chipsStock + " chips left in stock.");
    }
}

{
    Console.WriteLine("How many Candy have been sold today? 60 are in stock.");
    int candySold = int.Parse(Console.ReadLine());
    if (candySold > candyStock)
    {
        Console.WriteLine("That value is too high. Stock not adjusted.");
    }
    else if (candySold <= candyStock)
    {
        candyStock = candyStock - candySold;
        Console.WriteLine("There are " + candyStock + " candy left in stock.");
    }
}

const int sodaRestock = 40;
const int chipsRestock = 20;
const int candyRestock = 40;

Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked: "
  );
if (sodaStock <= sodaRestock)
{
    Console.WriteLine("Soda needs to be restocked.");
}
if (chipsStock <= chipsRestock)
{
    Console.WriteLine("Chips needs to be restocked.");
}
if (candyStock <= candyRestock)
{
    Console.WriteLine("Candy needs to be restocked.");
}
{
    Console.WriteLine("Goodbye!");
}