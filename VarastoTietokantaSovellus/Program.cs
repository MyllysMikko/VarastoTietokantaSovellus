int input;
input = 0;

Console.WriteLine("VARASTONHALLINTO");
Console.WriteLine("1 - Lisää uusi tuote");
Console.WriteLine("2 - Poista tuote");
Console.WriteLine("3 - Tulosta eri tuotteiden määrä");
Console.WriteLine("4 - Tulosta kaikki tuotteet");
Console.WriteLine("5 - Muokkaa tuotenimeä");
Console.WriteLine("0 - Lopeta sovellus");

Console.WriteLine("Valintasi on: ");

while(true)
{
    input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        Console.WriteLine("Lisäsit uuden tuotteen:");
        Console.WriteLine("Tuotteen id:");
        Console.WriteLine("Tuotten nimi:");
        Console.WriteLine("Tuotteen hinta:");
        Console.WriteLine("Varaston Saldo:");
        string userId = Console.ReadLine();
        string userTuoteNimi = Console.ReadLine();
        string userTuoteHinta = Console.ReadLine();
        string userVarastoSaldo = Console.ReadLine();

    }
    else if (input == 2)
    {
        Console.WriteLine("Poistit tuotteen:");
        Console.WriteLine("Anna Tuotteen Id:");
        string userId = Console.ReadLine();
    }
    else if (input == 3)
    {
        Console.WriteLine("Tulostit eri tuotteiden määrän:");
        Console.WriteLine("Anna Tuotteen Id:");
    }
    else if (input == 4)
    {
        Console.WriteLine("Tulostit kaikki tuotteet:");
    }
    else if (input == 5)
    {
        Console.WriteLine("Muokkasit tuotteen nimeä:");
        Console.WriteLine("Anna Tuotteen Id:");
        Console.WriteLine("Anna uusi tuotteelle nimi:");
    }
    else if (input == 0)
    {
        Console.WriteLine("Lopetit Sovelluksen:");
        break;
    }
    

    
}