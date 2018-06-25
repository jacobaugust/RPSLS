using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        //member variables (has a)
        public string gameTypeSelection;
        public Computer computer;
        public string roundOutcome;

        public Player player;
        public Human playerOne;
        public Human playerTwo;
        public string playerOneRoundOneSelection;
        public string playerOneRoundTwoSelection;
        public string playerOneRoundThreeSelection;
        public string gameStatus;

        public int roundResult;




        //constuctor (spawner)
        public Game()
        {
            player = new Human();
            playerTwo = new Human();
            computer = new Computer();
            roundResult = 3;
        }

        //member methods(actions)
        public void GameIntroduction()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, and Spock.\n\nA modern twist on the classic rock, paper, and scissors game.\n\nThe rules are as follows:\n\n You will play a best out of three match against either a computer or another player.\n\nBelow are the options and their potential outcomes:\n\nRock crushes Scissors\nScissors cut Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n\nHit Enter to begin.");
            Console.ReadLine();

        }


        public void GameMenu()
        {
            //select game type single player or head to head
            player.PlayerGeneration();
            Console.WriteLine("Welcome " + player.name + "... please select which game mode you would like to play:\n\nFor SINGLE PLAYER enter 1\n\nFor HEAD TO HEAD enter 2.");
            gameTypeSelection = Console.ReadLine();
            switch (gameTypeSelection)
            {
                case "1":
                    SinglePlayerGame();
                    break;
                case "2":
                    HeadToHeadGame();
                    break;
                default:
                    Console.WriteLine("Please enter a 1 for SINGLE PLAYER or 2 for HEAD TO HEAD.");
                    Console.ReadLine();


                    GameMenu();
                    break;

            }
        }
        //Single Player Game
        public void SinglePlayerGame()

        {
            for (int i = 0; i < 3; i++)
            {

                if (roundResult < 2)
                {
                    Console.WriteLine("COMPUTER WINS THE GAME!");
                    GameMenu();
                }
                if (roundResult > 4)
                {
                    Console.WriteLine("PLAYER ONE WINS THE GAME!");
                    GameMenu();
                }

                //capture selection



                SinglePlayerResultCheck();

            }

            //capture selection

            //list selection

            //check result



        }

        void SinglePlayerResultCheck()
        {
            player.RoundSelector();
            switch (player.humanSelection)
            {
                case "1":
                    CheckRock();
                    break;
                case "2":
                    CheckPaper();
                    break;
                case "3":
                    CheckScissors();
                    break;
                case "4":
                    CheckLizard();
                    break;
                case "5":
                    CheckSpock();
                    break;
                default:
                    player.RoundSelector();
                    break;

            }
        }


        void CheckRock()
        {
            computer.RoundSelector();
            switch (computer.computerSelection)
            {
                case "1":
                    Console.WriteLine("Computer also selected rock... try again.");
                    SinglePlayerGame();
                    break;
                case "2":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    SinglePlayerGame();
                    break;
                case "3":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    SinglePlayerGame();
                    break;
                case "4":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    SinglePlayerGame();
                    break;
                case "5":
                    Console.WriteLine("You lost the round.");
                    roundResult++;
                    SinglePlayerGame();
                    break;
                default:
                    GameIntroduction();
                    break;

            }
        }


        void CheckPaper()
        {
            switch (computer.computerSelection)
            {
                case "1":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    break;
                case "2":
                    Console.WriteLine("You Tied!... try again.");
                    break;
                case "3":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                case "4":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                case "5":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    break;
                default:
                    GameMenu();
                    break;

            }
        }

        void CheckScissors()
        {
            switch (computer.computerSelection)
            {
                case "1":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                case "2":
                    Console.WriteLine("You won the round.");
                    roundResult++;

                    break;
                case "3":
                    Console.WriteLine("Tie Round... try again.");
                    break;
                case "4":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    break;
                case "5":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                default:
                    GameIntroduction();
                    break;

            }
        }





        void CheckLizard()
        {
            switch (computer.computerSelection)
            {
                case "1":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                case "2":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    break;
                case "3":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                case "4":
                    Console.WriteLine("Tie Round... try again.");
                    player.RoundSelector();
                    break;
                case "5":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    break;
                default:
                    GameMenu();
                    break;
            }
        }

        void CheckSpock()
        {
            switch (computer.computerSelection)
            {
                case "1":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    break;
                case "2":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                case "3":
                    Console.WriteLine("You lost the round.");
                    roundResult--;
                    break;
                case "4":
                    Console.WriteLine("You won the round.");
                    roundResult++;
                    break;
                case "5":
                    Console.WriteLine("Tie Round... try again.");

                    break;
                default:
                    GameMenu();
                    break;
            }



        }











        //Head to Head Game
        public void HeadToHeadGame()
        {
            for (int i = 0; i < 3; i++)
            {
                if (roundResult < 2)
                {
                    Console.WriteLine("PLAYER TWO WINS THE GAME!");
                    GameMenu();
                }
                if (roundResult > 4)
                {
                    Console.WriteLine("PLAYER ONE WINS THE GAME!");
                    GameMenu();
                }
                HeadtoHeadResultCheck();
            }

            //capture selection



            //list selection

            //check result
            void HeadtoHeadResultCheck()
            {
                player.RoundSelector();
                Console.Clear();
                Console.WriteLine("Pass to next player.");
                switch (player.humanSelection)
                {
                    case "1":
                        CheckRock();
                        break;
                    case "2":
                        CheckPaper();
                        break;
                    case "3":
                        CheckScissors();
                        break;
                    case "4":
                        CheckLizard();
                        break;
                    case "5":
                        CheckSpock();
                        break;
                    default:
                        player.RoundSelector();
                        break;

                }
            }



            void CheckRock()
            {
                playerTwo.RoundSelector();
                switch (playerTwo.humanSelection)
                {
                    case "1":
                        Console.WriteLine("Computer also selected rock... try again.");
                        HeadToHeadGame();
                        break;
                    case "2":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        HeadToHeadGame();
                        break;
                    case "3":
                        Console.WriteLine("Player One the round.");
                        roundResult++;
                        HeadToHeadGame();
                        break;
                    case "4":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        HeadToHeadGame();
                        break;
                    case "5":
                        Console.WriteLine("Player Two won the round.");
                        roundResult++;
                        HeadToHeadGame();
                        break;
                    default:
                        GameMenu();
                        break;

                }
            }


            void CheckPaper()
            {
                switch (playerTwo.humanSelection)
                {
                    case "1":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        break;
                    case "2":
                        Console.WriteLine("You Tied!... try again.");
                        break;
                    case "3":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    case "4":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    case "5":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        break;
                    default:
                        GameMenu();
                        break;

                }
            }

            void CheckScissors()
            {
                switch (playerTwo.humanSelection)
                {
                    case "1":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    case "2":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;

                        break;
                    case "3":
                        Console.WriteLine("Tie Round... try again.");
                        break;
                    case "4":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        break;
                    case "5":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    default:
                        GameMenu();
                        break;

                }
            }





            void CheckLizard()
            {
                switch (playerTwo.humanSelection)
                {
                    case "1":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    case "2":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        break;
                    case "3":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    case "4":
                        Console.WriteLine("Tie Round... try again.");
                        player.RoundSelector();
                        break;
                    case "5":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        break;
                    default:
                        GameMenu();
                        break;
                }
            }

            void CheckSpock()
            {
                switch (playerTwo.humanSelection)
                {
                    case "1":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        break;
                    case "2":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    case "3":
                        Console.WriteLine("Player Two won the round.");
                        roundResult--;
                        break;
                    case "4":
                        Console.WriteLine("Player One won the round.");
                        roundResult++;
                        break;
                    case "5":
                        Console.WriteLine("Tie Round... try again.");
                        break;
                    default:
                        GameMenu();
                        break;
                }

            }
        }



    }
    //display round result

    //display game status


}





