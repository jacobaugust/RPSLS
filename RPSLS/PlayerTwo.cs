using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PlayerTwo
    {
        //member variables
        public string playerTwoName;
        public string playerTwoScissors;
        public string playerTwoPaper;
        public string playerTwoRock;
        public string playerTwoLizard;
        public string PlayerTwoSpock;
        public string playerTwoRoundOneSelection;
        public string playerTwoRoundTwoSelection;
        public string playerTwoRoundThreeSelection;
        //constructor
        public PlayerTwo()
        {

        }
        //member methods
        public void RoundOneSelector()
        {
            Console.WriteLine("Welcome to Round One!\n\n Pick from the gesture options below.\n\n\n Enter 1 for ROCK\nEnter 2 for PAPER\nEnter 3 for SCISSORS\nEnter 4 for Lizard\nEnter5 for Spock.");
            playerTwoRoundOneSelection = Console.ReadLine();
        }
        public void RoundTwoSelector()
        {
            Console.WriteLine("Round Two!\n\nPick from the gesture options below!\n\n\n Enter 1 for ROCK\nEnter 2 for PAPER\nEnter 3 for SCISSORS\nEnter 4 for Lizard\nEnter5 for Spock.");
            playerTwoRoundTwoSelection = Console.ReadLine();
        }
        public void RoundThreeSelector()
        {
            Console.WriteLine("Round Three!\n\nPick from the gesture options below!\n\n\n Enter 1 for ROCK\nEnter 2 for PAPER\nEnter 3 for SCISSORS\nEnter 4 for Lizard\nEnter5 for Spock.");
            playerTwoRoundTwoSelection = Console.ReadLine();
        }
        public List<string> SelectionList()
        {
            List<string> selections = new List<string>() {playerTwoRoundOneSelection, playerTwoRoundTwoSelection, playerTwoRoundThreeSelection};
            return selections;
        }

    }
}
