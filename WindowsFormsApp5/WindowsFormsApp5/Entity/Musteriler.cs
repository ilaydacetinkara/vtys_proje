using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Musteriler
    {
        [Key] public string musteri_no { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string adres { get; set; }

        public ICollection<Perakende_satis> Satis { get; set; }
        public ICollection<Veresiye_satis> veresiye_Satis { get; set; }

        public ICollection<Odeme> odemes { get; set; }

    }
}
