using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.FizzBuzz.Infrastructure.Interfaces
{
    public interface IStrategy
    {
        string GetExtraRule(short number);
    }
}
