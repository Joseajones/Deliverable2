using System;

namespace Del2
{
    class Program
    {
        static void Main(string[] args)
        {
            String headsOrTailsGuess;
            int numberOfFlips;
            int correctCount;
            int userImput;
                        Random CoinFlip = new Random();

            Console.Write("Welcome to the Heads or Tails game " +
                "\nGuess which side will show more times, Heads or Tails?  ");
            
            headsOrTailsGuess = Console.ReadLine();

            if (string.IsNullOrEmpty(headsOrTailsGuess))
            {
                Console.WriteLine("Sorry, you need to make a selection to conntinue, try again and select Heads or tails");
                
                headsOrTailsGuess = Console.ReadLine();
            } 

            if (headsOrTailsGuess == "Heads")
            {
                userImput = 0;
            } else
            {
                userImput = 1;
            }

            Console.Write("How many times would you like the coin to be flipped? ");

            numberOfFlips = int.Parse (Console.ReadLine());
             
            correctCount = 0;


            for (int i = 0; i < numberOfFlips; i++)
            {

                int flip = CoinFlip.Next(0, 2);

                if (flip == userImput)
                {
                    correctCount++;
                    Console.WriteLine("Head");
                } 
                
                else 
                {
                    Console.WriteLine("Tail");
                }

               
            }

            decimal percentage =  (decimal) correctCount / numberOfFlips * 100;

            Console.WriteLine( "Your guess, " + headsOrTailsGuess + ", came up "  + correctCount + " time (s) \nThat's " + percentage + "%");
            Console.ReadLine();
        } 
    } 
}
