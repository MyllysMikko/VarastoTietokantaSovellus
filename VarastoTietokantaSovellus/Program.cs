int input;
input = 0;

Console.WriteLine("VARASTONHALLINTO");
Console.WriteLine("1 - Lisää uusi tuote");
Console.WriteLine("2 - Poista tuote");
Console.WriteLine("3 - Tulosta eri tuotteiden määrä");
Console.WriteLine("4 - Tulosta kaikki tuotteet");
Console.WriteLine("5 - Muokkaa tuotenimeä");
Console.WriteLine("0 - Lopeta sovellus");

Console.WriteLine("Valintasi on:");

while (true)
{
    input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        Console.WriteLine("Valitsit 1:");
    }
    else if (input == 2)
    {
        Console.WriteLine("Valitsit 2:");
    }
    else if (input == 3)
    {
        Console.WriteLine("Valitsit 3:");
    }
    else if (input == 4)
    {
        Console.WriteLine("Valitsit 4:");
    }
    else if (input == 5)
    {
        Console.WriteLine("Valitsit 5:");
    }
    else if (input == 0)
    {
        Console.WriteLine("Lopetit Sovelluksen:");
    }

    
}