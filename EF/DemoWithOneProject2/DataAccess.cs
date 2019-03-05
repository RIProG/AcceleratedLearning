using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoWithOneProject2
{
    public class DataAccess
    {

        private readonly FruitContext _context;

        public DataAccess()
        {
            _context = new FruitContext();
        }

        public void AddCategoriesAndFruits()
        {

            var skenfrukt = new FruitCategory { Name = "Skenfrukt" };
            var äktatorr = new FruitCategory { Name = "Äkta Torr Frukt" };
            var äktasaftig = new FruitCategory { Name = "Äkta Saftig Frukt" };

            var ananas = new Fruit { Name = "Ananas", Category = skenfrukt, Price = 10.3M };
            var banan = new Fruit { Name = "Banan", Category = äktatorr, Price = 5 };
            var äpple = new Fruit { Name = "Äpple", Category = skenfrukt, Price = 4 };
            var kiwi = new Fruit { Name = "Kiwi", Category = äktasaftig, Price = 3 };
            var päron = new Fruit { Name = "Päron", Category = äktasaftig, Price = 6 };

            var basket1 = new Basket()
            {
                Name = "Min kundkorg",
                FruitInBaskets = new List<FruitInBasket>
                {
                    new FruitInBasket {Fruit = ananas},
                    new FruitInBasket {Fruit = päron}
                }
            };

            var basket2 = new Basket()
            {
                Name = "Min kundkorg2",
                FruitInBaskets = new List<FruitInBasket>
                {
                    new FruitInBasket {Fruit = äpple},
                    new FruitInBasket {Fruit = kiwi}
                }
            };

            var basket3 = new Basket()
            {
                Name = "Min kundkorg3",
                FruitInBaskets = new List<FruitInBasket>
                {
                    new FruitInBasket {Fruit = ananas},
                    new FruitInBasket {Fruit = äpple}
                }
            };

            _context.FruitCategories.Add(skenfrukt);
            _context.FruitCategories.Add(äktatorr);
            _context.FruitCategories.Add(äktasaftig);

            _context.Fruits.Add(äpple);
            _context.Fruits.Add(ananas);
            _context.Fruits.Add(kiwi);
            _context.Fruits.Add(päron);
            _context.Fruits.Add(banan);

            _context.Baskets.Add(basket1);
            _context.Baskets.Add(basket2);
            _context.Baskets.Add(basket3);


            _context.SaveChanges();

        }

        internal IEnumerable<Fruit> GetAllFruitsInBasktes(int id)
        {
            return _context.FruitInBasket.Where(x => x.BasketId == id).Include(x => x.Fruit).Select(x => x.Fruit).ToList();

        }

        internal IEnumerable<Basket> GetAllBaskets()
        {
            return _context.Baskets.Select(x => x).ToList();
        }

        public List<Fruit> GetFruitsInCategory(string v)
        {
            return _context.Fruits.Where(x => x.Category.Name == v).ToList();
        }

        internal List<Fruit> GetAllFruits()
        {
            //return _context.Fruits;
            return _context.Fruits.Include(x => x.Category).ToList();
        }

        public void ClearDatabase()
        {
            _context.RemoveRange(_context.FruitCategories);
            _context.RemoveRange(_context.Fruits);
            _context.RemoveRange(_context.Baskets);

            //foreach (var fruit in _context.Fruits)
            //{
            //    _context.Remove(fruit);
            //}
            //foreach (var fruitCategory in _context.FruitCategories)
            //{
            //    _context.Remove(fruitCategory);
            //}
            _context.SaveChanges();

        }
    }
}