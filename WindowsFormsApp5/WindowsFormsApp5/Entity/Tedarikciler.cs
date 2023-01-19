using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Tedarikciler
    {
        [Key] public string tedarikci_no { get; set; }
        public string isim { get; set; }
        public string adres { get; set; }
        public int telefon { get; set; }

        public ICollection<Urun_girdi> urun_Girdis { get; set; }
    }
}
