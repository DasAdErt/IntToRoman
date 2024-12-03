using System;
using System.Collections.Generic;
using System.Text;

namespace IntToRaman
{
    public class IntToRoman
    {
        public string roman_numbers(int num)
        {
            List<string> cs = new List<string> { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            List<int> vs = new List<int> { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < cs.Count; i++)
            {
                while (num >= vs[i])
                {
                    ans.Append(cs[i]);
                    num -= vs[i];
                }
            }
            return ans.ToString();
        }

        public static void Main()
        {
            IntToRoman intToRoman = new IntToRoman();
            string number = intToRoman.roman_numbers(998);
            Console.WriteLine("Roman Number is ", number);
        }
    }
}