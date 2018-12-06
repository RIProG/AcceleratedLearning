using System.Collections.Generic;
using System;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToStringList
    {




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
        public List<string> AddStarsToNumbersHigherThan1000_Linq(List<int> list)
        {
            return list.Select(x => x > 1000 ? "***" + x + "***" : x.ToString()).ToList();
        }

        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> numbers)
        {
            var zipZapBoing = new List<string>();
            foreach (int item in numbers)
            {
                if (item < 0)
                {
                    string zip = "ZIP";
                    zipZapBoing.Add(zip);
                }
                else if (item > 0)
                {
                    string zap = "ZAP";
                    zipZapBoing.Add(zap);
                }
                else
                {
                    string boing = "BOING";
                    zipZapBoing.Add(boing);
                }
            }
            return zipZapBoing;
        }

        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing_Linq(List<int> list)
        {
            return list.Select(x => x < 0 ? "ZIP" : x > 0 ? "ZAP" : "BOING").ToList();
        }

        public List<string> LongOrShort(List<int> heightList)
        {
            var stringList = new List<string>();
            foreach (int height in heightList)
            {
                if (height <= 160 && height > 100)
                {
                    string message = $"{height}cm är kort";
                    stringList.Add(message);
                }
                else if (height > 160 && height < 220)
                {
                    string message = $"{height}cm är långt";
                    stringList.Add(message);
                }
            }
            return stringList;
        }

        public List<string> LongOrShort_Linq(List<int> list)
        {
            var newList = list.Where(x => (x <= 220 && x > 100)).ToList();
            return newList.Select(x => x <= 160 ? $"{x}cm är kort" : $"{x}cm är långt").ToList();
            //return list.Where(x => (x <= 160 && x > 100) $"{x}cm är kort" || (x > 160 && < 220) $"{x}cm är långt").ToList();
        }
    }
}