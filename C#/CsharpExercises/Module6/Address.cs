using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module6
{
    class Address
    {
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }

        public string GetFullStreet()
        {
            string combinedStreetName = $"{Street} {StreetNumber}";
            return (combinedStreetName);
        }

        public string FullStreet
        {
            get
            {
                return $"{Street} {StreetNumber}";
            }
        }

        void SetZipCode(string newvalue)
        {
            if (newvalue.Length == 6 && newvalue.All(Char.IsDigit))
            {
                ZipCode = newvalue;
            }
        }

        string GetZipCode()
        {
            return ZipCode;
        }
    }
}