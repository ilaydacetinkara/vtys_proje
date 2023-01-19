using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.Entity
{
    internal class Urun_girdi
    {
        [Key]public string girdi_no { get; set; }
        public DateTime tarih { get; set; }
        public int miktar { get; set; }
        public float birim_fiyat { get; set; }
        public float borc_bakiyesi { get; set; }
        public string tedarikci_no { get; set; }
        public Tedarikciler tedarikci;

        public string irsaliye_no { get; set; }
        public Irsaliye irsaliye;

        public string urun_kod { get; set; }
        public Urun urun;
    }
}
