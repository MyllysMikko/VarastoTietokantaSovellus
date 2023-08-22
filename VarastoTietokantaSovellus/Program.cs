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


{
    input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        Console.WriteLine("Lisäsit uuden tuotteen:");
    }
    else if (input == 2)
    {
        Console.WriteLine("Poistit tuotteen:");
    }
    else if (input == 3)
    {
        Console.WriteLine("Tulostit eri tuotteiden määrän:");
    }
    else if (input == 4)
    {
        Console.WriteLine("Tulostit kaikki tuotteet:");
    }
    else if (input == 5)
    {
        Console.WriteLine("Muokkasit tuotteen nimeä:");
    }
    else if (input == 0)
    {
        Console.WriteLine("Lopetit Sovelluksen:");
    }

    
}