using Kata.FizzBuzz.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.FizzBuzz.Infrastructure.Strategy
{
    public class FizzBuzzStrategy : IStrategy
    {
        public string GetExtraRule(short number)
        {
           if(number % 3 ==0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            return null;
        }
    }
}
