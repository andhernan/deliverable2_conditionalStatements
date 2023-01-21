using System.Runtime.CompilerServices;

namespace deliverable2_conditionalStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //looping to check run all tests
            //looops
            
            //for (int i = 1; i < 100; i++)
            //{
                //set variables to exist
                int gradeGuess;
                Console.WriteLine("What grade do you expect to get in ISM 4300?");

                //try catch block
                try
                {
                    gradeGuess = Convert.ToInt32(Console.ReadLine());

                    // move to actual grade letter associate

                    if (gradeGuess < 60 && gradeGuess > -1)
                    {
                        Console.WriteLine("Your letter Grade is F");
                    }
                    else if (gradeGuess < 70 && gradeGuess > 59)
                    {
                        Console.WriteLine("Your letter Grade is D");
                    }
                    else if (gradeGuess < 80 && gradeGuess > 69)
                    {
                        Console.WriteLine("Your letter Grade is C");
                    }
                    else if (gradeGuess < 90 && gradeGuess > 79)
                    {
                        Console.WriteLine("Your letter Grade is B");
                    }
                    else if (gradeGuess < 101 && gradeGuess >89)
                    {
                        Console.WriteLine("Your letter Grade is A");
                    }
                    else
                    {
                        Console.WriteLine("This number is out of the score range for a grade. \n");
                    }
                }

                catch
                {
                    Console.WriteLine("Please write a whole number. \n");
                }
            //}
        }
    }
}