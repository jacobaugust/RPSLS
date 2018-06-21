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
        public string RoundOneSelector()
        {
            Random rnd = new Random();
            int numberSelectionOne = rnd.Next(1, 7);
            computerPlayerRoundOneSelection = numberSelectionOne.ToString();
            return computerPlayerRoundOneSelection;
        }
        public string RoundTwoSelector()
        {
            Random rnd = new Random();
            int numberSelectionTwo = rnd.Next(1, 7);
            computerPlayerRoundTwoSelection = numberSelectionTwo.ToString();
            return computerPlayerRoundTwoSelection;

        }
        public string RoundThreeSelector()
        {
            Random rnd = new Random();
            int numberSelectionThree = rnd.Next(1, 7);
            computerPlayerRoundThreeSelection = numberSelectionThree.ToString();
            return computerPlayerRoundThreeSelection;
        }
        public List<string> SelectionList()
        {
            List<string> selections = new List<string>() { computerPlayerRoundOneSelection, computerPlayerRoundTwoSelection, computerPlayerRoundThreeSelection };
            return selections;
        }

        

    }
}
