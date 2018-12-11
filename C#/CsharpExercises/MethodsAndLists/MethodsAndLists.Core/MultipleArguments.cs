using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MethodsAndLists.Core.Enums;

namespace MethodsAndLists.Core
{
    public class MultipleArguments
    {
        public List<string> SomeToUpper(List<string> list, List<bool> toUpper)
        {
            var result = new List<string>();
            int i = 0;

            foreach (string item in list)
            {

                if (toUpper[i] == true)
                {
                    result.Add(item.ToUpper());
                }
                else
                {
                    result.Add(item);
                }

                i++;
            }
            return result;

            //string bigWord;

            //foreach (var word in list)
            //{
            //    if (word == "what")
            //    {
            //        bigWord = word.ToUpper();
            //        result.Add(bigWord);

            //    }
            //    else if (word == "does")
            //    {
            //        bigWord = word.ToUpper();
            //        result.Add(bigWord);
            //    }
            //    else if (word == "says")
            //    {
            //        bigWord = word.ToUpper();
            //        result.Add(bigWord);
            //    }
            //    else
            //        result.Add(word);
            //}
            //return result;
        }



        public List<double> MultiplyAllBy(int factor, List<double> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException();
            }

            var result = new List<double>();

            foreach (var item in numbers)
            {
                result.Add(item * factor);
            }
            return result;
        }

        public List<double> MultiplyAllBy_Linq(int factor, List<double> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentException();
            }

            return numbers.Select(x => x * factor).ToList();

        }

        public List<string> NearbyElements(int position, List<string> list)
        {

            if (position < 0 || position > list.Count - 1)
                throw new ArgumentException();

            var result = new List<string>();

            if (position > 0)
                result.Add(list[position - 1]);

            result.Add(list[position]);

            if (position < list.Count - 1)
                result.Add(list[position + 1]);

            return result;

        }

        public List<List<int>> MultiplicationTable(int rowMax, int colMax)
        {
            if (rowMax <= 0 || colMax <= 0)
                throw new ArgumentException();

            var result = new List<List<int>>();
            for (int rowNumber = 1; rowNumber <= rowMax; rowNumber++)
            {
                var row = new List<int>();
                for (int colNumber = 1; colNumber <= colMax; colNumber++)
                {
                    row.Add(rowNumber * colNumber);
                }
                result.Add(row);
            }

            return result;
        }

        public List<List<int>> MultiplicationTable_Linq(int rowMax, int colMax)
        {
            if (rowMax <= 0 || colMax <= 0)
                throw new ArgumentException();

            return Enumerable.Range(1, rowMax).Select(r => Enumerable.Range(1, colMax).Select(c => c * r).ToList()).ToList();
        }

        public int ComputeSequenceSumOrProduct(int toNumber, bool sum)
        {
            int result = 1;

            if (toNumber <= 0)
            {
                throw new ArgumentException();
            }

            if (sum == true)
            {
                for (int i = 2; i <= toNumber; i++)
                {
                    result += i;
                }
            }

            else if (sum == false)
                for (int i = 2; i <= toNumber; i++)
                {
                    result *= i;
                }

            return result;

        }

        public int ComputeSequence(int toNumber, ComputeMethod sum)
        {
            int result = 1;

            if (toNumber <= 0)
            {
                throw new ArgumentException();
            }

            if (sum == ComputeMethod.Sum)
            {
                for (int i = 2; i <= toNumber; i++)
                {
                    result += i;
                }
            }

            else if (sum == ComputeMethod.Product)
                for (int i = 2; i <= toNumber; i++)
                {
                    result *= i;
                }

            return result;

        }

        public int[] CombineLists(int[] list1, int[] list2)
        {
            var combinedList = new List<int>();
            for (int i = 0; i < (list1.Length + list2.Length); i++)
            {
                if (list1.Length > i)
                    combinedList.Add(list1[i]);

                if (list2.Length > i)
                    combinedList.Add(list2[i]);
            }
            return combinedList.ToArray();
        }

        public int[] RotateList(int[] list, int rotation)
        {
            if (list == null)
            {
                throw new ArgumentException();
            }

            var result = new List<int>();
            result = list.ToList();

            if (rotation < 0)
            {
                rotation = rotation * (-1);
                for (int i = 0; i < rotation; i++)
                {
                    int internalCounter = 0;
                    foreach (var item in list)
                    {
                        if (item == list[0])
                        {
                            result[list.Length - 1] = item;
                        }
                        else
                            result[internalCounter - 1] = item;

                        internalCounter++;
                    }
                    list = result.ToArray();
                }

            }

            else if (rotation > 0)
            {
                for (int i = 0; i < rotation; i++)
                {
                    int internalCounter = 0;
                    foreach (var item in list)
                    {
                        if (item == list[list.Length - 1])
                        {
                            result[0] = item;
                        }
                        else
                            result[internalCounter + 1] = item;

                        internalCounter++;
                    }
                    list = result.ToArray();
                }

            }

            return result.ToArray();
        }
    }
}

