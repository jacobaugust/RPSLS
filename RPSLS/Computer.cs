using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public class Computer : Player
    {
        //member variables
        public string computerName;




        //constructor


        //member methods
        public override void PlayerGeneration()
        {
            //player name gather
            computerName = "Master Zorg";
        }
        public override void RoundSelector()
        {
            Random rnd = new Random();
            int numberSelectionOne = rnd.Next(1, 6);
            computerSelection = numberSelectionOne.ToString();

        }

    }
}

