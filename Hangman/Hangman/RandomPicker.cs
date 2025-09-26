using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class RandomPicker
    {

        private readonly string[] words = {
            "Argentina", 
            "Desk",
            "Literature",
            "Killme",
            "Ihatethis",
            "LOL",
            "Random",
            "Skopje"
        };

        private Random random;

        public RandomPicker()
        {
            random = new Random();
        }

        public string Pick()
        {
            return words[random.Next(words.Length)];
        }
    }
}
