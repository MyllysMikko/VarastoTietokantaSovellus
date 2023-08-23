using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarastoTietokantaSovellus
{
    public class Sqlkomennot
    {

        public bool AddTuote(string newId, string newTuotenimi, string newTuotehinta, string newVarastoSaldo)
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


    }
}
