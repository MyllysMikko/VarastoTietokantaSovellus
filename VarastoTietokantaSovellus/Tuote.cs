using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarastoTietokantaSovellus
{

    /// <summary>
    /// Tuotteen tiedot
    /// </summary>
    public class Tuote
    {
        [Key]
        public string? Id { get; set; }

        public string? Tuotenimi { get; set; }

        public string? Tuotehinta { get; set; }

        public string? VarastoSaldo { get; set; }

    }
}
