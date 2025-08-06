using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    public class Scrabble
    {
        private Dictionary<char, int> letterToScoreMap = new()
        {
            {'a', 1},
            {'b', 3},
            {'c', 3},
            {'d', 2},
            {'e', 1},
            {'f', 4},
            {'g', 2},
            {'h', 4},
            {'i', 1},
            {'j', 8},
            {'k', 5},
            {'l', 1},
            {'m', 3},
            {'n', 1},
            {'o', 1},
            {'p', 3},
            {'q', 10},
            {'r', 1},
            {'s', 1},
            {'t', 1},
            {'u', 1},
            {'v', 4},
            {'w', 4},
            {'x', 8},
            {'y', 4},
            {'z', 10}
        };

        private string processedWord;

        public Scrabble(string word)
        {            
            //TODO: do something with the word variable

            bool isValid = word.All(char.IsLetter);


            processedWord = word.ToLower();

        }

        public int score()
        {
            int totalScore = 0;

            //TODO: score calculation code goes here
            foreach (var letter in processedWord)
            {
                letterToScoreMap.TryGetValue(letter, out var score);
                totalScore += score;
            }

            return totalScore;
        }
    }
}
