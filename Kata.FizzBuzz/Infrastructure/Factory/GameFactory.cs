using Kata.FizzBuzz.Infrastructure.Interfaces;
using Kata.FizzBuzz.Infrastructure.Strategy;
using System;

namespace Kata.FizzBuzz.Infrastructure.Factory
{
    public class GameFactory : IGameFactory
    {
        public IGame CreateGameRules(string rules = null)
        {
            IGame game;
            switch (rules)
            {
                case "Whizz":
                    {
                        IStrategy whizzStrategy = new WhizzStrategy();
                        game = new Game(whizzStrategy.GetExtraRule);
                        break;
                    }                 
                case "FizzBuzz":
                    {
                        IStrategy fizzStrategy = new FizzBuzzStrategy();
                        game = new Game(fizzStrategy.GetExtraRule);
                        break;
                    }
                default:
                    game = new Game();
                    break;
            }
            return game;
        }
    }
}
