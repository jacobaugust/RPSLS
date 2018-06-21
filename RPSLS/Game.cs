using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables (has a)
        public string gameTypeSelection;
        public string playerOneName;
        public string playerTwoName;
        public string playerOneSelection;
        public string playerTwoSelection;
        PlayerOne playerOne;
        PlayerTwo playerTwo;
        ComputerPlayer computerPlayer;


    



    //constuctor (spawner)
    public Game()
    {

    }

    //member methods(actions)
    public void GameIntroduction()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, and Spock.\n\nA modern twist on the classic rock, paper, and scissors game.\n\nThe rules are as follows:\n\n You will play a best out of three match against either a computer or another player.\n\nBelow are the options and their potential outcomes:\n\nRock crushes Scissors\nScissors cut Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock");
        Console.ReadLine();
    }
    public void PlayerGeneration()
    {
        //player name gather
        Console.WriteLine("Player one please type your name");
        string playerOneName = Console.ReadLine();
    }
        public void GameMenu()
        {
            //select game type single player or head to head
            Console.WriteLine("Welcome " + playerOneName + "... please select which game mode you would like to play:\n\nFor SINGLE PLAYER enter 1\n\nFor HEAD TO HEAD enter 2.");
            switch (gameTypeSelection)
            {
                case "1":
                    SinglePlayerRoundOne();
                    break;
                case "2":
                    HeadToHeadRoundOne();
                    break;
                default:
                    Console.WriteLine("Please enter a 1 for SINGLE PLAYER or 2 for HEAD TO HEAD.");
                    Console.ReadLine();
                    GameMenu();
                    break;
            }
        }
        //Single Player Game
        public void SinglePlayerRoundOne()
        {
            playerOne = new PlayerOne();
            playerOne.RoundOneSelector();

        }
        public void SinglePlayerRoundTwo()
        {

        }
        public void SinglePlayerRoundThree()
        {

        }
        //Head to Head Game
        public void HeadToHeadRoundOne()
        {

        }
        public void HeadToHeadRoundTwo()
        {

        }
        public void HeadToHeadRoundThree()
        {

        }
    }
}


        

