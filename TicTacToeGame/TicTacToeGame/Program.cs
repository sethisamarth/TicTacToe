using System;

namespace TicTacToeGame
{
    class Program
    {
        //making array and   where no use of zero 

        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static int player = 1; //By default player 1 is set  

        static int choice; //This holds the choice at which position user want to mark   


        static void Main(string[] args)
        {


            Console.WriteLine("Player1:X and Player2:O");

            Console.WriteLine("\n");

            if (player % 2 == 0)//checking the chance of the player  

            {

                Console.WriteLine("Player 2 Chance");

            }

            else

            {

                Console.WriteLine("Player 1 Chance");

            }

            Console.WriteLine("\n");
            Board();
            choice = int.Parse(Console.ReadLine());//Taking users choice

            // checking position where user want to mark x or o
            if (arr[choice] != 'X' && arr[choice] != 'O')

            {

                if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  

                {

                    arr[choice] = 'O';

                    player++;

                }

                else

                {

                    arr[choice] = 'X';

                    player++;

                }
            }
            else //If there is any possition where user want to run and that is already marked then show message and load board again  

            {

                Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);

                Console.WriteLine("\n");
            }
            }

        // create board method
        private static void Board()

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);

            Console.WriteLine("     |     |      ");
        }
        //Checking that any player has won or not  

        private static int CheckWin()

        {


            //Winning Condition For First Row   

            if (arr[1] == arr[2] && arr[2] == arr[3])

            {

                return 1;

            }

            //Winning Condition For Second Row   

            else if (arr[4] == arr[5] && arr[5] == arr[6])

            {

                return 1;

            }

            //Winning Condition For Third Row   

            else if (arr[6] == arr[7] && arr[7] == arr[8])

            {

                return 1;

            }





            //Winning Condition For First Column       

            else if (arr[1] == arr[4] && arr[4] == arr[7])

            {

                return 1;

            }

            //Winning Condition For Second Column  

            else if (arr[2] == arr[5] && arr[5] == arr[8])

            {

                return 1;

            }

            //Winning Condition For Third Column  

            else if (arr[3] == arr[6] && arr[6] == arr[9])

            {

                return 1;

            }


            // Winning Condition For fourth Column


            else if (arr[1] == arr[5] && arr[5] == arr[9])

            {

                return 1;

            }

            else if (arr[3] == arr[5] && arr[5] == arr[7])

            {

                return 1;

            }




           // Checking For Draw

            // If all the cells or values filled with X or O then any player has won the match  

            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')

            {

                return -1;

            }


            else

            {

                return 0;

            }
        }
        }
    
}
