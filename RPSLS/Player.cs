using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public abstract class Player
    {
        //member variables
        public string handGesture;
        public string rock;
        public string paper;
        public string scissors;
        public string lizard;
        public string spock;
        public string gestureSelection;
        public string name;
        public string humanSelection;
        public string computerSelection;



        public abstract void RoundSelector();


        public abstract void PlayerGeneration();

        public List<string> GestureOptionsList()
        {
            List<string> gestures = new List<string>() { rock, paper, scissors, lizard, spock };
            return gestures;
        }



    }
}
