using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarastoTietokantaSovellus
{
    public class Varastotietokanta : DbContext
    {
        public DbSet<Tuote> Tuotteet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Niklas! Laita kohtaan "Catalog=Varasto" se miksi nimesit oman tietokantasi! Samoin salasana!
            string connection = "Data Source=.;Initial Catalog=TIETOKANTA;User Id=sa;Password=SALASANA;MultipleActiveResultSets=true;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
