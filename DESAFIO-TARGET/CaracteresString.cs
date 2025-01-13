using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_TARGET
{
    public class CaracteresString
    {
        public string ReverseString(string input)
        {
            char[] reversed = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversed[i] = input[input.Length - i - 1];
            }
            return new string(reversed);
        }
    }
}
