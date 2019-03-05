using System;
using System.Collections.Generic;
using System.Text;

namespace DemoWithOneProject2
{
    public class FruitCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Fruit> FruitsInCategory { get; set; }
    }
}
