using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogBeverage
{
    internal interface IBeverage
    {
        //Интерфейс коктейля содержит ID, Имя, описание, список компонентов и метод для присвоения ID.
        public uint id { get;}
        public string name { get; set; }
        public string description { get; set; }
        public int alcoholContent { get; set; }
        public List<Liquid> liquids { get; set; }
        private void SetId() { }
    }
}
