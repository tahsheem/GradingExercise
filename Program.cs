using System;

namespace SelectionStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade out of 100?");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*** *** *** *** *** ***");

            if (grade >= 95)
            {
                Console.WriteLine("Congratulations, You got A+");
            }

            else if (grade >= 90)
            {
                Console.WriteLine("Good Work, You got A!");
            }
            else if (grade >= 85)
            {
                Console.WriteLine("Nice Job, You got a B+");

            }
            else if (grade >= 80)
            {
                Console.WriteLine("You got a B!");
            }

            else if (grade >= 75)
            {
                Console.WriteLine("You got a C+.");

            }

            else if (grade >= 70)
            {
                Console.WriteLine("You got a C.");
            }
            else if (grade >= 65)
            {
                Console.WriteLine("You got a D+");

            }
            else if (grade >= 60)
            {

                Console.WriteLine("You got a D.");
            }
            else if (grade >= 59 || grade <= 50)
            {
                Console.WriteLine("Sorry to but have Failed!");
            }


        }
            }
        }
    

