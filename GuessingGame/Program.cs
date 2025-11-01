namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playing = true;
            int games = 0;
            int bestScore = int.MaxValue;


            Console.WriteLine("PLS ENTER YOUR NAME!");
            String name = Console.ReadLine();
            Console.WriteLine("Hello " + name);


            while (playing)
            {
                
                int botNum = random.Next(1, 51);
                int tries = 0;
                Console.WriteLine("Guess a number between 1 - 50\n");
                
                bool guessedRight = false;
                games++;
                while (!guessedRight) {
                    int userNum = Convert.ToInt32(Console.ReadLine());
                    tries++;
                    if (userNum == botNum)
                {
                    Console.WriteLine("\nCongrats " + name + "! Your guess was right with " +tries +" tries");
                        
                        

                        if ( tries < bestScore)
                        {
                            bestScore = tries;
                            Console.WriteLine("YESSSSS! NEW BEST SCORE IS " +bestScore +" TRIES!");
                        }
                        else
                        {
                            Console.WriteLine("Your best score is still " + bestScore +" tries");
                        }
                        guessedRight = true;
                }
                    else if (userNum > 50 || userNum < 1)
                    {
                        Console.WriteLine("Number out of range! Please guess a number between 1 - 50");
                        tries--;

                    }
                    else if (userNum > botNum)
                {
                    Console.WriteLine("Too high try again");
                }
                    
                    else
                    {
                        Console.WriteLine("\nToo low try again");
                    }

            }

                    Console.WriteLine("Wanna play again? (yes / no)");
                    string answer = Console.ReadLine().ToLower();
        
                    if (answer == "yes")
                {
                    playing = true;
                    Console.Clear();

                }
                         
                    else
                {
                    playing = false;
                    Console.WriteLine("Thank you " +name+ " for playing");
                    Console.WriteLine("Your total games played " + games + " games");
                    Console.WriteLine("Your best score is " + bestScore + " tries");
                }
            }
            Console.ReadKey();
        }
    }
}
