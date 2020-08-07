
using Kata.FizzBuzz.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.FizzBuzz.Infrastructure.Strategy
{
    public class WhizzStrategy : IStrategy
    {
        public string GetExtraRule(short number)
        {
            if (number % 7 == 0)
            {
                return "Whizz";
            }
            return null;
        }
    }
}
