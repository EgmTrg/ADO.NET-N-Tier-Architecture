using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Entity
{
    public class Table : Attribute
    {
        public string TableName { get; set; }
        public string PrimaryColumn { get; set; }
    }
}
