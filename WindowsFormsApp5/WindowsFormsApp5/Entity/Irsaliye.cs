using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Irsaliye
    {
        [Key] public string irsaliye_no { get; set; }
        public DateTime tarih { get; set; } 
        public float birim_fiyat { get; set; }
        public int miktar { get; set; }
        
        public string urun_kod { get; set; }
        public Urun urun;

        public ICollection<Urun_girdi> urun_Girdis { get; set; }
       
    }
}
