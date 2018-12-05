using System.Collections.Generic;
using System;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToStringList
    {

        public List<string> LongOrShort(List<int> heightList)
        {
            throw new NotImplementedException();
        }

        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public List<string> AddStarsToNumbersHigherThan1000(List<int> numbers)
        {
            var starString = new List<string>();
            string starItem;
            foreach (var item in numbers)
            {
                if (item > 1000)
                {
                    starItem = $"***{item}***";
                    starString.Add(starItem);
                }
                else
                {
                    starItem = $"{item}";
                    starString.Add(starItem);
                }

            }
                return starString;
        }

        public List<string> AddStars(List<int> numbers)
        {
            var starString = new List<string>();
            string starItem;
            foreach (var item in numbers)
            {
                starItem = $"***{item}***";
                starString.Add(starItem);
            }
            return starString;
        }

        public List<string> AddStars_Linq(List<int> list)
        {
            return list.Select(x => "***" + x + "***").ToList();
        }

        public List<string> AddStarsToNumbersHigherThan1000_Linq(List<int> list)
        {
            var starString = new List<string>();
            return starString;
        }
    }
}