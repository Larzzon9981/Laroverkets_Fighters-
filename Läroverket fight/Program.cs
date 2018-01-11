using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Läroverketfigthers

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fight me Bish";
            Console.SetWindowSize(35, 10);
            Random randomness = new Random();
            int playerHP = randomness.Next(10, 20);
            int enemyHP = randomness.Next(8, 18);

            int playerDmg = randomness.Next(2, 5);
            int enemyDmg = randomness.Next(2, 4);

            string userInput;

            //Game loop
            while (playerHP > 0 && enemyHP > 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Player Hp" + playerHP);
                Console.WriteLine("Enemy Hp" + enemyHP);

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Enemy Hp" + enemyHP);

                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("1: Attack \n2: Heal\n\nUser input:");
                userInput = Console.ReadLine();

                //User Choice
                if (userInput == "1") //attack
                {
                     playerDmg = randomness.Next(2, 5);

                    enemyHP -= playerDmg;


                    Console.WriteLine("Player attacked for " + playerDmg);


                }
                else if(userInput == "2") //heal
                {
                    int healAmount = randomness.Next(1, 2);
                    playerHP += randomness.Next(1, 2);
                    Console.WriteLine("Player healed for " + healAmount);

                }
                else

              
                //Enemy Attacks
                enemyDmg = randomness.Next(2, 4);
                playerHP -= enemyDmg;




                Console.WriteLine("Enemy attacked for " + enemyDmg);
                Thread.Sleep(500);


                

            }  //End of while loop

            //When we are here someone is dead
            if (playerHP < 1)
            {
                // if player died
                Console.Write("You died");
            }
            else
            Console.Write("Enemy  Won!");
        }
        
    }
}
