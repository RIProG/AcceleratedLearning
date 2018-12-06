using System.Collections.Generic;
using System.Linq;
using System;

namespace MethodsAndLists.Core
{
    public class NumberListToString
    {
        // Demo: returnera "fjärde talet är jättestort" om det är större än 10000



        public string ReportFirstAndLastValue(List<int> numbers)
        {
            string first = $"{numbers[0]}";
            string last = $"{numbers[numbers.Count - 1]}";
            string reportBack = $"Första siffran är {first} och sista siffran är {last}";
            return reportBack;
        }

        public string ReportFirstAndLastValue_Linq(List<int> numbers)
        {
            string result = $"Första siffran är {numbers.First()} och sista siffran är {numbers.Last()}";
            return result;
        }

        public string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {
            int counter = 0;
            string reportBack;
            foreach (int number in numbers)
            {
                if (number > 100)
                {
                    counter++;
                }
            }
            if (counter == numbers.Count)
                reportBack = "Alla nummer är högre än 100";
            else
                reportBack = "Något nummer är lägre än (eller lika med) 100";

            return reportBack;
        }

        public string ReportIfAllValuesAreHigherThan100_Linq(List<int> list)
        {
            return list.Any(x => x < 100) ? "Något nummer är lägre än (eller lika med) 100" : "Alla nummer är högre än 100";
            //return list.Count(x => x < 100) > 0 ? "xxx" : "yyy";
        }

        public string ReportNumberOfNegativeValues(List<int> numbers)
        {
            int counter = 0;
            string reportBack;
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    counter++;
                }
            }

            if (counter == 0)
                reportBack = "Jippi! Det finns inga negativa tal i listan";
            else if (counter == 1)
                reportBack = "Det finns ett negativt tal i listan";
            else
                reportBack = $"Det finns {counter} st negativa tal i listan";

            return reportBack;
        }

        public string ReportNumberOfNegativeValues_Linq(List<int> list)
        {
            string reportBack;
            int counter = list.Count(x => x < 0);
            if (counter == 0)
                reportBack = "Jippi! Det finns inga negativa tal i listan";
            else if (counter == 1)
                reportBack = "Det finns ett negativt tal i listan";
            else
                reportBack = $"Det finns {counter} st negativa tal i listan";

            return reportBack;
        }
    }
}