using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzz.Models
{
    public class FizzBuzzModel
    {
        public int Fizz { get; set; }
        public int Buzz { get; set; }
        public int Value { get; set; }

        public FizzBuzzModel(string fizz, string buzz)
        {
            Fizz = Convert.ToInt32(fizz);
            Buzz = Convert.ToInt32(buzz);
        }

        public string FizzBuzzCheck(string value)
        {
            Value = Convert.ToInt32(value);

            if (Value % Fizz == 0)
            {
                value = "Fizz";
            }

            if (Value % Buzz == 0)
            {
                value = "Buzz";
            }

            if (Value % Fizz == 0 && Value % Buzz == 0)
            {
                value = "FizzBuzz";
            }

            return value;
        }

    }
}
