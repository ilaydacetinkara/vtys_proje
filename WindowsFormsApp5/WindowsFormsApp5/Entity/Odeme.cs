using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Odeme
    {
        [Key] public string odeme_no { get; set; }
        public DateTime tarih { get; set; }
        public int miktar { get; set; }
        public string musteri_no { get; set; }
        public Musteriler musteri; 
        public string satis_no { get; set; }
        public Perakende_satis perakende_Satis;
        public Veresiye_satis veresiye_Satis;
    }
}
