using VarastoTietokantaSovellus;

int input;

Console.WriteLine("VARASTONHALLINTO");
Console.WriteLine("1 - Lisää uusi tuote");
Console.WriteLine("2 - Poista tuote");
Console.WriteLine("3 - Tulosta eri tuotteiden määrä");
Console.WriteLine("4 - Tulosta kaikki tuotteet");
Console.WriteLine("5 - Muokkaa tuotenimeä");
Console.WriteLine("0 - Lopeta sovellus");



while (true)
{
    do
    {
        Console.Write("Valitse toiminto: ");
    } while (!int.TryParse(Console.ReadLine(), out input));

    

    if (input == 1)
    {

        Console.Write("Tuotteen id: ");
        string userId = Console.ReadLine();
        Console.Write("Tuotten nimi: ");
        string userTuoteNimi = Console.ReadLine();
        Console.Write("Tuotteen hinta: ");
        string userTuoteHinta = Console.ReadLine();
        Console.Write("Varaston Saldo: ");
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
        
        Console.Write("Anna Tuotteen Id: ");
        string userId = Console.ReadLine();
         if (CheckId(userId))
        {
            if (Sqlkomennot.DeleteTuote(userId))
            {
                Console.WriteLine($"Tuote ID:llä {userId} on poistettu Tietokannasta");
            }
            else
            {
                Console.WriteLine("Tuotetta ei löydetty Tietokannasta");
            }
        }
    }
    else if (input == 3)
    {
        Console.Write("Anna Tuotteen Id: ");
        string userId = Console.ReadLine();
        if (CheckId(userId))
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
        Console.Write("Anna Tuotteen Id: ");
        string userId = Console.ReadLine();
        Console.Write("Anna uusi tuotteelle nimi: ");
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
        Console.WriteLine("Lopetit Sovelluksen");
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
            Console.WriteLine("ID:ssa ei saa olla välilyöntejä!");
            return false;
        }
        if (!Id.All(char.IsNumber))
        {
            Console.WriteLine("ID saa siältää vain numeroita!");
            return false;
        }
        if (Id.Length != 4)
        {
            Console.WriteLine("Id:n täytyy olla neljän pitkä!");
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
            Console.WriteLine("Numerossa ei saa olla välilyöntejä!");
            return false;
        }
        if (!number.All(char.IsNumber))
        {
            Console.WriteLine("Numero ei saa siältää kirjaimia!");
            return false;
        }
        if (number.Length > 15)
        {
            Console.WriteLine("Numero on liian pitkä!");
            return false;
        }
        return true;
    }
}