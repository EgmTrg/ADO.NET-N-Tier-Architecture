using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.ORM.Entity
{
    public class Kitap
    {
        public int KitapNo { get; set; }
        public string KitapAd { get; set; }
        public int SayfaSayisi { get; set; }
        public int Puan { get; set; }
        public int YazarNo { get; set; }
        public int TurNo { get; set; }
    }
}
