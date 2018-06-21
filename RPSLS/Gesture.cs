using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        //member variables
        public Rock rock;
        public Paper paper;
        public Scissors scissors;
        public Lizard lizard;
        public Spock spock;

        //constructor

        //member methods
        public List<Gesture> GestureList()
        {
            List<Gesture> gestures = new List<Gesture>() { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
            return gestures;
        }

    }
}
