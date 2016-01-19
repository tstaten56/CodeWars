using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace QuickTest
{
    public class Kata
    {

        static void Main(string[] args)
        {

        }

        public string Rps(string p1, string p2)
        {
            if (p1 == "rock" || p2 == "rock")
            {
                return compareRock(p1, p2);
            }
            if (p1 == "scissors" || p2 == "scissors")
            {
                return compareScissors(p1, p2);
            }
            if (p1 == "paper" || p2 == "paper")
            {
                return comparePaper();
            }

            return "Should not reach this";
        }

        private string comparePaper()
        {
            return "Draw!";
        }

        private string compareScissors(string p1, string p2)
        {
            if (p1.Contains("scissors"))
            {
                if (p2.Contains("paper"))
                {
                    return "Player 1 won!";
                }
                if (p2.Contains("scissors"))
                {
                    return "Draw!";
                }
            }
            if (p1.Contains("paper"))
            {
                return "Player 2 won!";
            }
            return "Should not reach this";
        }

        private string compareRock(string p1, string p2)
        {
            if (p1.Contains("rock"))
            {
                if (p2.Contains("rock"))
                {
                    return "Draw!";
                }
                if (p2.Contains("paper"))
                {
                    return "Player 2 won!";
                }
                if (p2.Contains("scissors"))
                {
                    return "Player 1 won!";
                }
                return "This should not be reached";
            }

            if (p2.Contains("rock"))
            {
                if (p1.Contains("paper"))
                {
                    return "Player 1 won!";
                }
                if (p1.Contains("scissors"))
                {
                    return "Player 2 won!";
                }

                return "This should not be reached";
            }
            return "This should not be reached";
        }
    }
}
