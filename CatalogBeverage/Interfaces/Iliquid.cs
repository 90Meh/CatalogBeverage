using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogBeverage
{
    internal interface Iliquid
    {
        //Интерфейс компонента напитка. Содержит имя, содержание алкоголя и описание
        public string name { get; set; }
        public int alcoholContent { get; set; }
        public string description { get; set; }
    }
}
