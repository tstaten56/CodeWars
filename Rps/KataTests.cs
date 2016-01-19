using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTest.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void RpsTest()
        {
            var kata = new Kata();

            Assert.AreEqual("Player 1 won!", kata.Rps("rock", "scissors"));
            Assert.AreEqual("Player 1 won!", kata.Rps("scissors", "paper"));
            Assert.AreEqual("Player 1 won!", kata.Rps("paper", "rock"));

            Assert.AreEqual("Player 2 won!", kata.Rps("scissors", "rock"));
            Assert.AreEqual("Player 2 won!", kata.Rps("paper", "scissors"));
            Assert.AreEqual("Player 2 won!", kata.Rps("rock", "paper"));

            Assert.AreEqual("Draw!", kata.Rps("rock", "rock"));
            Assert.AreEqual("Draw!", kata.Rps("scissors", "scissors"));
            Assert.AreEqual("Draw!", kata.Rps("paper", "paper"));
        }

    }
}
