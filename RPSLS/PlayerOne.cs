using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class PlayerOne
    {
        //member variables
        public string playerOneName;
        public string playerOneScissors;
        public string playerOnePaper;
        public string playerOneRock;
        public string playerOneLizard;
        public string playerOneSpock;
        public string playerOneRoundOneSelection;
        public string playerOneRoundTwoSelection;
        public string playerOneRoundThreeSelection;
        
        
    
        //constructor
        public PlayerOne()
        {

        }

        //member methods
        public void RoundOneSelector()
        {
            Console.WriteLine("Welcome to Round One!\n\nPick from the gesture options below.\n\n\n Enter 1 for ROCK\nEnter 2 for PAPER\nEnter 3 for SCISSORS\nEnter 4 for Lizard\nEnter 5 for Spock.");
            playerOneRoundOneSelection = Console.ReadLine();
        }
        public void RoundTwoSelector()
        {
            Console.WriteLine("Round Two!\n\nPick from the gesture options below and see if you can beat the computer!\n\n\n Enter 1 for ROCK\nEnter 2 for PAPER\nEnter 3 for SCISSORS\nEnter 4 for Lizard\nEnter 5 for Spock.");
            playerOneRoundTwoSelection = Console.ReadLine();
        }
        public void RoundThreeSelector()
        {
            Console.WriteLine("Round Three!\n\nPick from the gesture options below!\n\n\n Enter 1 for ROCK\nEnter 2 for PAPER\nEnter 3 for SCISSORS\nEnter 4 for Lizard\nEnter 5 for Spock.");
            playerOneRoundThreeSelection = Console.ReadLine();
        }
        public List<string> SelectionList()
        {
            List<string> selections = new List<string>() {playerOneRoundOneSelection, playerOneRoundTwoSelection, playerOneRoundThreeSelection};
            return selections;
        }
        


    }
}
