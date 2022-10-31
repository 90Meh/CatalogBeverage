using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogBeverage
{
    internal class Beverage : IBeverage
    {
        // Класс коктейля. Реализует интерфейс коктейля
        public uint id => throw new NotImplementedException();
        public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<Liquid> liquids { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int alcoholContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
