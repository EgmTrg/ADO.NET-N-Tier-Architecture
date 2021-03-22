using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Entity
{
    public class Tur : Table
    {
        public override string PrimaryKey => "kitapno";
        public int turno { get; set; }
        public string ad { get; set; }
    }
}
