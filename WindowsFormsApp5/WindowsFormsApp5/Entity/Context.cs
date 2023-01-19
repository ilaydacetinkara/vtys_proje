using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Context : DbContext
    {
        public DbSet<Urun> uruns { get; set; }
        public DbSet<Irsaliye> ırsaliyes { get; set; }
        public DbSet<Musteriler> musterilers { get; set;}
        public DbSet<Satici> saticis { get; set; }
        public DbSet<Perakende_satis> perakende_satis { get;private set; }
        public DbSet<Veresiye_satis> veresiye_Satis { get; set; }
        public DbSet<Odeme> odemes { get; set; }
        public DbSet<Tedarikciler> tedarikcilers { get; set; }
        public DbSet<Urun_girdi> urun_Girdis { get; set; }
    }
}
