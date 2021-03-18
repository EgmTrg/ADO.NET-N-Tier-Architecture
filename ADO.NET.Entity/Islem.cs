using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Entity
{
    public class Islem : EntityBase
    {
        public override string PrimaryKey => "islemno";
        public int islemno { get; set; }
        public int ogrno { get; set; }
        public int kitapno { get; set; }
        public DateTime atarih { get; set; }
        public DateTime vtarih { get; set; }

    }
}
