using Kata.FizzBuzz.Infrastructure.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kata.FizzBuzz.Infrastructure.Interfaces
{
    public interface IGameFactory
    {
        IGame CreateGameRules(string rules);
    }
}
