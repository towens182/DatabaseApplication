using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Music_Store
{
    public class MyRegex
    {
        string namePattern = "[A-Z][a-z]+";
        string phonePattern = @"(\d{3})-(\d{4})";

        public bool AcceptName(string name)
        {
            Regex nameRegex = new Regex(namePattern);

            if (nameRegex.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AcceptPhone(string phone)
        {
            Regex phoneRegex = new Regex(phonePattern);

            if (phoneRegex.IsMatch(phone))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetPhone(string phone)
        {
            string number = "";

            MatchCollection matches = Regex.Matches(phone, phonePattern);

            foreach (Match match in matches)
            {
                number = number + match.Groups[1].Value + match.Groups[2].Value;
            }
            return Int32.Parse(number);
        }


    }
}
