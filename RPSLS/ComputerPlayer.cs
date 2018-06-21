using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer
    {
        //member variables
        public string computerPlayerScissors;
        public string computerPlayerPaper;
        public string computerPlayerRock;
        public string computerPlayerLizard;
        public string computerPlayerSpock;
        public string computerPlayerRoundOneSelection;
        public string computerPlayerRoundTwoSelection;
        public string computerPlayerRoundThreeSelection;
        //constructor

        //member methods
        public void RoundOneSelector()
        {
            Random rnd = new Random();
            int numberSelectionOne = rnd.Next(1, 7);
            computerPlayerRoundOneSelection = numberSelectionOne.ToString();
            Console.ReadLine
        }
        public void RoundTwoSelector()
        {

        }
        public void RoundThreeSelector()
        {

        }
        public List<string> SelectionList()
        {
            List<string> selections = new List<string>() { ComputerRoundOneSelection, ComputerTwoRoundTwoSelection, ComputerTwoRoundThreeSelection };
            return selections;
        }

        

    }
}
