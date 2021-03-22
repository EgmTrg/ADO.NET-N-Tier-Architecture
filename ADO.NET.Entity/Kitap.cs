using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Entity
{
    [Table(PrimaryColumn = "kitapno",TableName ="Kitap")]
    public class Kitap : Table
    {
        public int kitapno { get; set; }
        public string ad { get; set; }
        public int sayfasayisi { get; set; }
        public int puan { get; set; }
        public int yazarno { get; set; }
        public int turno { get; set; }

    }
}
