using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public record RomanNumber(int value)
    {
        private readonly int _value = value;
        public int Value => _value;
        public static RomanNumber Parse(String input) 
        {
            return new(0);
        }
    }
}
