using VarastoTietokantaSovellus;

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

while (true)
{
    input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {

        Console.WriteLine("Tuotteen id:");
        string userId = Console.ReadLine();
        Console.WriteLine("Tuotten nimi:");
        string userTuoteNimi = Console.ReadLine();
        Console.WriteLine("Tuotteen hinta:");
        string userTuoteHinta = Console.ReadLine();
        Console.WriteLine("Varaston Saldo:");
        string userVarastoSaldo = Console.ReadLine();
        if (CheckId(userId))
        {
            if (CheckNimi(userTuoteNimi))
            {
                if (CheckNumbers(userTuoteHinta))
                {
                    if (CheckNumbers(userVarastoSaldo))
                    {
                        Sqlkomennot.AddTuote(userId, userTuoteNimi, userTuoteHinta, userVarastoSaldo);
                        Console.WriteLine($"Tuote {userTuoteNimi} on lisätty Tietokantaan");
                    }
                }
            }
        }

    }
    else if (input == 2)
    {
        
        Console.WriteLine("Anna Tuotteen Id:");
        string userId = Console.ReadLine();
        CheckId(userId);
        {
            if (Sqlkomennot.DeleteTuote(userId))
            {
                Console.WriteLine($"Tuote {userId} on poistettu Tietokannasta");
            }
            else
            {
                Console.WriteLine("Tuotetta ei löydetty Tietokannasta");
            }
        }
    }
    else if (input == 3)
    {
        Console.WriteLine("Tulostit eri tuotteiden määrän:");
        Console.WriteLine("Anna Tuotteen Id:");
        string userId = Console.ReadLine();
        CheckId(userId);
        {
            Sqlkomennot.QueryingTuoteById(userId);
        }
    }
    else if (input == 4)
    {
       Sqlkomennot.QueryingTuotteet();
    }
    else if (input == 5)
    {
        Console.WriteLine("Muokkasit tuotteen nimeä:");
        Console.WriteLine("Anna Tuotteen Id:");
        string userId = Console.ReadLine();
        Console.WriteLine("Anna uusi tuotteelle nimi:");
        string userNimi = Console.ReadLine();
        if (CheckId(userId))
        {
            if (CheckNimi(userNimi))
            {
                if (Sqlkomennot.ChangeTuoteNimi(userId, userNimi))
                {
                    Console.WriteLine("Tuotteen nimi on muutettu");
                }
                else
                {
                    Console.WriteLine("Tuotetta ei löydetty Tietokannasta");
                }
            }
        }

    }
    else if (input == 0)
    {
        Console.WriteLine("Lopetit Sovelluksen:");
        break;
    }


    bool CheckId(string Id)
    {
        if (string.IsNullOrWhiteSpace(Id))
        {
            Console.WriteLine("Älä syötä tyhjää!");
            return false;
        }
        else if (Id.Contains(' '))
        {
            Console.WriteLine("Ei välilyöntejä saa olla Id:ssa!");
            return false;
        }
        if (!Id.All(char.IsNumber))
        {
            Console.WriteLine("Id:n pitäisi olla vaan numeroita ei kirjaimia!");
            return false;
        }
        if (Id.Length != 4)
        {
            Console.WriteLine("Id:n täytyy neljän pitkä!");
            return false;
        }
        return true;
    }
    bool CheckNimi(string nimi)
    {
        if (string.IsNullOrWhiteSpace(nimi))
        {
            Console.WriteLine("Älä syötä tyhjää!");
            return false;
        }
        else if (nimi.Contains(' '))
        {
            Console.WriteLine("Ei välilyöntejä saa olla nimessä!");
            return false;
        }
        if (nimi.Length > 15)
        {
            Console.WriteLine("Liian pitkä nimi!");
            return false;
        }
        return true;
    }
    bool CheckNumbers(string number)
    {
        if (string.IsNullOrWhiteSpace(number))
        {
            Console.WriteLine("Älä syötä tyhjää!");
            return false;
        }
        else if (number.Contains(' '))
        {
            Console.WriteLine("Ei välilyöntejä saa olla numerossa!");
            return false;
        }
        if (!number.All(char.IsNumber))
        {
            Console.WriteLine("Numero pitäisi olla vaan numeroita ei kirjaimia!");
            return false;
        }
        if (number.Length > 15)
        {
            Console.WriteLine("Ei saa olla liian pitkä!");
            return false;
        }
        return true;
    }
}