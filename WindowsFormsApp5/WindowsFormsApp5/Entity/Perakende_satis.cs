using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Perakende_satis
    {
        [Key] public string satis_no { get; set; }
        public DateTime tarih { get; set; }
        public int miktar { get; set; }
        public float birim_fiyat { get; set; }

        public string musteri_no { get; set; }
        public Musteriler musteri;
        public string urun_kod { get; set; }
        public Urun urun;

        public ICollection<Odeme> odemes { get; set; }
    }
}
