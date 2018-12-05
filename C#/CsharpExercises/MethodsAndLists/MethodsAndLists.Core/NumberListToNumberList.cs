using System;
using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToNumberList
    {



        public List<int> NegateEachNumber(List<int> numbers)
        {
            var negatedNumbers = new List<int>();
            int negatedNumber;
            foreach (int number in numbers)
            {
                negatedNumber = number * (-1);
                negatedNumbers.Add(negatedNumber);
            }
            return negatedNumbers;

        }

        public List<int> DivideEachNumberBy100(List<int> numbers)
        {
            var dividedNumbers = new List<int>();
            int dividedNumber;
            foreach (int number in numbers)
            {
                dividedNumber = number / 100;
                dividedNumbers.Add(dividedNumber);
            }
            return dividedNumbers;
        }



        public List<int> DoubleEachNumber(List<int> numbers)
        {
            var doubledNumbers = new List<int>();
            foreach (int number in numbers)
            {
                int d = number * 2;
                doubledNumbers.Add(d);
            }
            return doubledNumbers;
        }

        public List<int> DoubleEachNumber_Linq(List<int> input)
        {
            List<int> doubledNumbers = input.Select(x => x * 2).ToList();
            return doubledNumbers;
        }


        public List<int> Add100ToEachNumber(List<int> numbers)
        {
            var increasedNumbers = new List<int>();
            foreach (int number in numbers)
            {
                int d = number + 100;
                increasedNumbers.Add(d);
            }
            return increasedNumbers;
        }

        public List<int> Add100ToEachNumber_Linq(List<int> input)
        {
            List<int> increasedNumbers = input.Select(x => x + 100).ToList();
            return increasedNumbers;
        }

        public List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var thousandList = new List<int>();
            foreach (int number in numbers)
            {
                if (number > 1000)
                {
                    thousandList.Add(number);
                }
            }
            return thousandList;
        }

        public List<int> GetNumbersHigherThan1000_Linq(List<int> input)
        {
            return input.Where(x => x > 1000).ToList();
        }

        public List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var dividedList = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 5 == 0)
                {
                    dividedList.Add(number);
                }
            }
            return dividedList;
        }

        public List<int> GetNumbersDividableByFive_Linq(List<int> input)
        {
            return input.Where(x => x % 5 == 0).ToList();
        }

        public List<int> DivideEachNumberBy100_Linq(List<int> input)
        {
            return input.Select(x => x / 100).ToList();
        }

        public List<int> NegateEachNumber_Linq(List<int> input)
        {
            return input.Select(x => x * (-1)).ToList();
        }

        public List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            var result = new List<int>();
            int numberCounter = 1;
            foreach (var number in numbers)
            {
                int newNumber = number;

                if (numberCounter <= 3)
                    newNumber = number + 50;

                result.Add(newNumber);
                numberCounter++;
            }

            return result;
        }

        public List<int> Add50ToFirstThreeElements_Linq(List<int> input)
        {
            var threeFifty = input.Take(3).Select(x => x + 50).ToList();
            threeFifty.AddRange(input.Skip(3));
            return threeFifty;
        }

        public List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            var result = new List<int>();
            int counter = 1;
            foreach (var number in numbers)
            {
                int newNumber;

                if (counter % 2 == 0)
                    newNumber = number + 70;
                else
                    newNumber = number;

                result.Add(newNumber);

                counter++;
            }

            return result;
        }

        public List<int> Add70ToEverySecondElement_Linq(List<int> input)
        {
            var newList = input.Select((x, i) => i % 2 == 0 ? x+70 : x+0).ToList();
            return newList;
        }
    }
}