using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Human : Player
    {
        //member variables




        //constructor


        //member methods
        public override void PlayerGeneration()
        {
            //player name gather
            Console.WriteLine("Please type your name");
            name = Console.ReadLine();

        }
        public override void RoundSelector()
        {
            Console.WriteLine("Make your selection!\n\nPlayer One will go first and Player Two will go second. Pick from the gesture options below.\n\n\nEnter 1 for ROCK\nEnter 2 for PAPER\nEnter 3 for SCISSORS\nEnter 4 for Lizard\nEnter 5 for Spock.");
            humanSelection = Console.ReadLine();

        }

    }
}
