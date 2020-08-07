using Kata.FizzBuzz.Infrastructure.Interfaces;
using System;

namespace Kata.FizzBuzz 
{
    public class Game : IGame
    {
        private string[] _fizzBuzzOutput;
        private Func<short, string> _extraRules;
        public Game(Func<short, string> extraRules = null)
        {
            _fizzBuzzOutput = new string[100];
            _extraRules = extraRules;
        }
        public string[] GetGameOutput()
        {
            for (short i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    _fizzBuzzOutput[i - 1] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    _fizzBuzzOutput[i - 1] = "Buzz";
                }

                if(_extraRules != null)
                    _fizzBuzzOutput[i - 1] = _extraRules(i);

                if (_fizzBuzzOutput[i - 1] == null)
                    _fizzBuzzOutput[i - 1] = i.ToString();
            }
            return _fizzBuzzOutput;
        }
    }
}
