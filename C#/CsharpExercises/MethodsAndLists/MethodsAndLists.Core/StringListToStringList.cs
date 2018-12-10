using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class StringListToStringList
    {
        public IEnumerable<string> GetEverySecondElement(string[] strings)
        {
            if (strings == null)
            {
                throw new ArgumentNullException();
            }

            //var result = new List<string>();
            //int counter = 1;

            //foreach (string item in strings)
            //{
            //    if (counter % 2 == 0)
            //    {
            //        result.Add(item);
            //    }
            //    counter++;
            //}
            //return result;

            return strings.Where((x, i) => (i+1) % 2 == 0);

        }
    }
}
