using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp5.Entity
{
    internal class Satici
    {
        [Key] public string satici_no { get; set; }
        public string kullanici_adı { get; set; }
        public string sifre { get; set; }
        public bool arayuz_erisim { get; set; }
    }
}
