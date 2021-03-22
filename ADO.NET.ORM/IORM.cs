using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.ORM
{
    public interface IORM<Table> where Table : class
    {
        DataTable Select();
        bool Insert(Table t);
        bool Update(Table t);
        bool Delete(int id);
    }
}
