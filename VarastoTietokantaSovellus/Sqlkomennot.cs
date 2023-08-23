using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarastoTietokantaSovellus
{
    public class Sqlkomennot
    {

        public static bool AddTuote(string newId, string newTuotenimi, string newTuotehinta, string newVarastoSaldo)
        {
            using Varastotietokanta varastotietokanta = new();
            Tuote tuote = new()
            {
                Id = newId,
                Tuotenimi = newTuotenimi,
                Tuotehinta = newTuotehinta,
                VarastoSaldo = newVarastoSaldo
            };

            varastotietokanta.Tuotteet?.Add(tuote);
            int affected = varastotietokanta.SaveChanges();

            return affected == 1;
        }

        public static bool ChangeTuoteNimi(string id, string newName)
        {
            using Varastotietokanta varastotietokanta = new();
            Tuote tuoteUpdate = varastotietokanta.Tuotteet.FirstOrDefault(tuote => tuote.Id == id);

            if (tuoteUpdate != null)
            {
                tuoteUpdate.Tuotenimi = newName;
                int affected = varastotietokanta.SaveChanges();
                return affected == 1;
            }
            else
            {
                return false;
            }
        }

        public static void QueryingTuotteet()
        {
            using Varastotietokanta varastotietokanta = new();

            Console.WriteLine("Rekisteröityneet pelaajat:");
            IQueryable<Tuote> allTuotteet = varastotietokanta.Tuotteet;

            foreach (Tuote tuote in allTuotteet)
            {
                Console.WriteLine($"ID:{tuote.Id} Tuotenimi:{tuote.Tuotenimi} Hinta:{tuote.Tuotehinta} Varastossa:{tuote.VarastoSaldo}");
            }
        }

        public static void QueryingTuoteById(string id)
        {
            using Varastotietokanta varastotietokanta = new();


            Tuote tuote = varastotietokanta.Tuotteet.FirstOrDefault(tuote => tuote.Id == id);

            if (tuote != null)
            {
                Console.WriteLine($"Tuotetta {tuote.Tuotenimi} (ID:{tuote.Id}) on varastossa {tuote.VarastoSaldo} kappaletta");
            }
            else
            {
                Console.WriteLine($"Tuote ID {id} ei löydy tietokannasta");
            }

        }



        public static int DeleteTuote(string id)
        {
            using Varastotietokanta varastotietokanta = new();
            Tuote? tuoteDelete = varastotietokanta.Tuotteet.Find(id);

            if (tuoteDelete != null)
            {
                varastotietokanta.Remove(tuoteDelete);
                int affected = varastotietokanta.SaveChanges();
                return affected;
            }
            else
            {
                return 0;
            }

        }





    }
}
