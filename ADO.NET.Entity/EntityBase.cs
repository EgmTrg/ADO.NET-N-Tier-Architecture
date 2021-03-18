using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET.Entity
{
    public abstract class EntityBase
    {
        public abstract string PrimaryKey 
        { 
            get; 
        }
        // abstract ifadesi uygulandigi ozelligi `tamamlanmamis` olarak isaretler ve sadece child class ya da alt sekmelerde kullanilabilir.
        // genellikle child class'da ise override kullanilarak `tamamlanmamis` olarak isaretlenen yapinin ustune yazarak tamamlar.
    }
}
