using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_input;
            int  inputvalue1=0;
            bool exc1 = true;
            Console.WriteLine("Guess the secret Number");
         
            while (exc1)
            {
                Console.Write("Please enter a number between 1-100:");
                first_input = Console.ReadLine();

                if (true == int.TryParse(first_input, out inputvalue1))
                {
                    int val =int.Parse(first_input);
                    if (val < 1 || val > 100)
                    {
                        exc1 = true;
                        Console.WriteLine("Error --> You Did Not Enter a number between 1-100! Try Again");
                      
                    }
                    else
                    {
                        exc1 = false;
                        if (first_input == "42")
                        {
                            Console.WriteLine("Correct");
                        }
                        else
                        {
                            exc1 = true;
                            Console.WriteLine("Incorrect");

                        }



                    }
                }
                else
                {
                    exc1 = true;
                    Console.WriteLine("Error --> You Did Not Enter The Number Correctly! Try Again");
                   
                 
                }
            }
          
            Console.WriteLine("<Press Enter To End Program>");
            Console.Read();


        }

       


    }



}
