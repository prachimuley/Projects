using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToDecimalNameSpace
{
    public class RomanToDecimal
    {
        private Dictionary<char, int> map = new Dictionary<char, int>();
        public RomanToDecimal()
        {
            initializeDictonary();
        }

        private void initializeDictonary()
        {
            map['I'] = 1;
            map['V'] = 5;
            map['X'] = 10;
            map['L'] = 50;
            map['C'] = 100;
            map['D'] = 500;
            map['M'] = 1000;
        }
        //This function will convert Roman Numerals to decimals for input value 1 to 4000.
        public int converter(String s)
        {
            int number = 0;

            for (int i=0; i < s.Length-1; i++)
            {
                if ((map[s[i]]) >= map[s[i + 1]])
                {
                    number = map[s[i]] + number;
                }
            }
            number = number + map[s[s.Length-1]];
            return number;
        }
    }
}
