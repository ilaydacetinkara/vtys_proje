using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Urun
    {
        [Key] public string urun_kod { get; set; }
        public string barkod { get; set; }
        public float girdi_fiyat { get; set; }
        public int miktar { get; set; }
        public float karlilik { get; set; }

        public ICollection<Irsaliye> ırsaliyes { get; set; }
        public ICollection<Perakende_satis> satis { get; set; }
        public ICollection<Veresiye_satis> veresiye_Satis { get; set; }
        public ICollection<Urun_girdi> urun_Girdis { get; set; }
    }
}
