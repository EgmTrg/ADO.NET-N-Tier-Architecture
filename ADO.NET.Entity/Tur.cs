using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Entity
{
    [Table(PrimaryColumn ="turno",TableName ="Tur")]
    public class Tur : Table
    {
        public int turno { get; set; }
        public string ad { get; set; }
    }
}
