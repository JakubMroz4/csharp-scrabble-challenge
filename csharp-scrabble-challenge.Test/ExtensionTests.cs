using csharp_scrabble_challenge.Main;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Test
{
    [TestFixture]
    public class ExtensionTests
    {

        [TestCase("{street}", 12)] //extension double word
        [TestCase("[street]", 18)] //extension triple word
        [TestCase("{s}treet", 7)] //extension double word
        [TestCase("[st]reet", 10)] //extension triple word
        [TestCase("[st]ree{t}", 11)] //extension triple word
        [TestCase("[st}ree[t}", 0)] //extension triple word
        [TestCase("{quirky}", 44)] //extension double word
        [TestCase("[quirky]", 66)] //extension triple word
        [TestCase("{OXyPHEnBUTaZoNE}", 82)]
        [TestCase("[OXyPHEnBUTaZoNE]", 123)]
        [TestCase("[{h}o1s{e}]", 0)] // error case (zero for errors)
        [TestCase("{h}ous{e}", 13)]
        [TestCase("[{h}ous{e}]", 39)]
        [TestCase("[h}ous{e}]", 0)] //Error case (zero for errors)
        [TestCase("", 0)]
        [TestCase(" ", 0)]
        [TestCase(" \t\n", 0)]
        [TestCase("\n\r\t\b\f", 0)]
        [TestCase("a", 1)]
        [TestCase("f", 4)]
        [TestCase("OXyPHEnBUTaZoNE", 41)]
        [TestCase("quirky", 22)]
        [TestCase("street", 6)]
        [TestCase("]street[", 0)]
        public void ExtendedCriteriaTests(string word, int targetScore)
        {
            Assert.AreEqual(this.GetWordScore(word), targetScore);
        }

        private int GetWordScore(string word) => new Scrabble(word).score();
    }
}
