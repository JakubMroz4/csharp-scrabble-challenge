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

        // [] triple points
        // {} double points

        private const char startDoublePoints = '{';
        private const char endDoublePoints = '}';

        private const char startTriplePoints = '[';
        private const char endTriplePoints = ']';

        bool isDoublePointsActive = false;
        bool isTriplePointsActive = false;

        int doublePointsMultiplier = 2;
        int triplePointsMultiplier = 3;

        public Scrabble(string word)
        {
            processedWord = word.ToLowerInvariant();
            // assumes brackets are valid, ie no "{street{" or mixing double with triple points

        }

        public int score()
        {
            int totalScore = 0;

            foreach (var letter in processedWord)
            {

                switch (letter)
                {
                    case startDoublePoints:
                        isDoublePointsActive = true;
                        break;
                    case endDoublePoints:
                        isDoublePointsActive = false; 
                        break;
                    case startTriplePoints:
                        isTriplePointsActive = true;
                        break;
                    case endTriplePoints:
                        isTriplePointsActive = false;
                        break;

                }

                letterToScoreMap.TryGetValue(letter, out var score);

                if (isDoublePointsActive)
                    score *= doublePointsMultiplier;
                    
                if (isTriplePointsActive)
                    score *= triplePointsMultiplier;
                    

                totalScore += score;
            }

            return totalScore;
        }
    }
}
