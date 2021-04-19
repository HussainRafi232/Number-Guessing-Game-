using System;

namespace testing
{
    class Program
    {

        static void Main()
        {
            Console.Title = "Number Guessing Game";
            Program p = new Program();

            p.title();
            p.instructions();

            Console.ReadKey();
        }

        public void instructions()  /// Instructions for main menu
        {
            int userIn;
            userIn = Int32.Parse(Console.ReadLine());
            switch (userIn)
            {
                case 1:
                    Console.Clear();
                    menuOnetitle();
                    difficulty();
                    break;

                case 2:
                    Console.Clear();
                    gamerules();
                    break;

                case 3:
                    System.Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong option. Please try again");
                    instructions();
                    break;
            }
        }

        public void menuOnetitle()   /// Instructions for Difficulty menu 
        {
            Console.WriteLine("------------");
            Console.WriteLine("DIFFCULTY");
            Console.WriteLine("------------");
            Console.WriteLine("Select your difficulty by entering the relevant numbers");
            Console.WriteLine("1- Easy");
            Console.WriteLine("2- Medium");
            Console.WriteLine("3- Hard");
            Console.WriteLine("4- Return to main menu");
        }

        public void difficulty() /// Difficulty menu 
        {

            int userIn;
            userIn = Int32.Parse(Console.ReadLine());
            switch (userIn)
            {
                case 1:

                    GameEasy();
                    break;

                case 2:
                    GameMedium();
                    break;

                case 3:
                    GameHard();
                    break;

                case 4:
                    Console.Clear();
                    Main();
                    break;

                default:
                    Console.WriteLine("Wrong option. Please try again");
                    difficulty();
                    break;
            }
        }

        public void title() /// Title for main menu 
        {

            Console.WriteLine("-----------------------------");
            Console.WriteLine("NUMBER GUESSING GAME");
            Console.WriteLine("BY HUSSAIN RAFI");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1- Play game");
            Console.WriteLine("2- Game rules");
            Console.WriteLine("3- Exit");
        }

        public void gamerules()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("GAME RULES");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1- Easy difficulty is based on 3 turns and numbers"); Console.WriteLine("between 1 to 5. Who gets the most number of correct guesses wins.\n");
            Console.WriteLine("2- Medium difficulty is based on 5 turns and numbers"); Console.WriteLine("between 1 to 10. Who gets the most number of correct guesses wins.\n");
            Console.WriteLine("3- Hard difficulty is based on 10 turns and numbers"); Console.WriteLine("between 1 to 30. Who gets the most number of correct guesses wins.");
            Console.WriteLine("\nEnter 1 to return to main menu");
            int u;
            u = Int32.Parse(Console.ReadLine());
            if (u == 1)
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Wrong option try again");

            }
        }

        public void GameEasy() /// Easy difficulty game 
        {
            try
            {
                // 3 turns. 
                Console.Clear();
                Random rdm = new Random();
                int cpuNum = rdm.Next(1, 5);
                int player1Num;
                int cpuScore = 0, player1Score = 0;
                for (int turn = 1; turn <= 3; turn++)
                {
                    Console.WriteLine("Enter a number between 1-10 ");
                    Console.WriteLine("Turn no# " + turn + " :");
                    player1Num = Int32.Parse(Console.ReadLine());
                    if (player1Num == cpuNum)
                    {
                        player1Score += 1;

                    }
                    else
                    {
                        cpuScore += 1;
                    }

                    Console.Clear();
                }

                if (player1Score > cpuScore)
                {
                    Console.WriteLine("Final score:");
                    Console.WriteLine("P1 score:" + player1Score);
                    Console.WriteLine("CPU score:" + cpuScore);
                    Console.WriteLine("You win ! Good job. ");
                    Console.WriteLine("\nWould you like to play again? Y/n");
                    playagainGE();
                }
                else
                {
                    Console.WriteLine("Final score:");
                    Console.WriteLine("P1 score:" + player1Score);
                    Console.WriteLine("CPU score:" + cpuScore);
                    Console.WriteLine("You lose ! Better luck next time.");
                    Console.WriteLine("\nWould you like to play again? Y/n");
                    playagainGE();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                GameEasy();
            }



        }

        public void GameMedium() /// Medium difficulty game 
        {
            try
            {
                // 5 turns. 
                Console.Clear();
                Random rdm = new Random();
                int cpuNum = rdm.Next(1, 10);
                int player1Num;
                int cpuScore = 0, player1Score = 0;
                for (int turn = 1; turn <= 5; turn++)
                {
                    Console.WriteLine("Enter a number between 1-10 ");
                    Console.WriteLine("Turn no# " + turn + " :");
                    player1Num = Int32.Parse(Console.ReadLine());
                    if (player1Num == cpuNum)
                    {
                        player1Score += 1;

                    }
                    else
                    {
                        cpuScore += 1;
                    }

                    Console.Clear();
                }

                if (player1Score > cpuScore)
                {
                    Console.WriteLine("Final score:");
                    Console.WriteLine("P1 score:" + player1Score);
                    Console.WriteLine("CPU score:" + cpuScore);
                    Console.WriteLine("You win ! Good job. ");
                    Console.WriteLine("\nWould you like to play again? Y/n");
                    playagainGM();
                }
                else
                {
                    Console.WriteLine("Final score:");
                    Console.WriteLine("P1 score:" + player1Score);
                    Console.WriteLine("CPU score:" + cpuScore);
                    Console.WriteLine("You lose ! Better luck next time.");
                    Console.WriteLine("\nWould you like to play again? Y/n");
                    playagainGM();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                GameMedium();
            }



        }

        public void GameHard() /// Hard difficulty game 
        {
            try
            {
                // 5 turns. 
                Console.Clear();
                Random rdm = new Random();
                int cpuNum = rdm.Next(1, 30);
                int player1Num;
                int cpuScore = 0, player1Score = 0;
                for (int turn = 1; turn <= 10; turn++)
                {
                    Console.WriteLine("Enter a number between 1-10 ");
                    Console.WriteLine("Turn no# " + turn + " :");
                    player1Num = Int32.Parse(Console.ReadLine());
                    if (player1Num == cpuNum)
                    {
                        player1Score += 1;

                    }
                    else
                    {
                        cpuScore += 1;
                    }

                    Console.Clear();
                }

                if (player1Score > cpuScore)
                {
                    Console.WriteLine("Final score:");
                    Console.WriteLine("P1 score:" + player1Score);
                    Console.WriteLine("CPU score:" + cpuScore);
                    Console.WriteLine("You win ! Good job. ");
                    Console.WriteLine("\nWould you like to play again? Y/n");
                    playagainGH();
                }
                else
                {
                    Console.WriteLine("Final score:");
                    Console.WriteLine("P1 score:" + player1Score);
                    Console.WriteLine("CPU score:" + cpuScore);
                    Console.WriteLine("You lose ! Better luck next time.");
                    Console.WriteLine("\nWould you like to play again? Y/n");
                    playagainGH();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                GameHard();
            }



        }


        public void playagainGE() /// Retry function if you want to play again
        {
            string u;
            u = Console.ReadLine();
            if (u == "y" || u == "Y")
            {
                Console.Clear();
                GameEasy();
            }
            if (u == "n" || u == "N")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Wrong option. Please try again");
                playagainGE();
            }
        }

        public void playagainGH() /// Retry function if you want to play again
        {
            string u;
            u = Console.ReadLine();
            if (u == "y" || u == "Y")
            {
                Console.Clear();
                GameHard();
            }
            if (u == "n" || u == "N")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Wrong option. Please try again");
                playagainGH();
            }
        }

        public void playagainGM() /// Retry function if you want to play again
        {
            string u;
            u = Console.ReadLine();
            if (u == "y" || u == "Y")
            {
                Console.Clear();
                GameMedium();
            }
            if (u == "n" || u == "N")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Console.WriteLine("Wrong option. Please try again");
                playagainGM();
            }
        }
    }
}
