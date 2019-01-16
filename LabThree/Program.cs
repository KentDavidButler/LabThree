//code Writen By Kent Butler
//Date written 1/15/2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;

            Console.WriteLine("Good Day,");
            Console.WriteLine("and welcome to the useless number program!");
            Console.Write("Whome do I have the pleasure of assisting today? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);

            bool again = true;
            while (again)
            {
                String input;
                bool validInput;
                int inputNum;

                Console.Write("Enter a number between 1 and 100: ");

                do
                {
                    input = Console.ReadLine();
                    validInput = int.TryParse(input, out inputNum);
                    if (!validInput)
                    {
                        Console.WriteLine(name + ", Please type a valid Number");
                        validInput = false;
                    }
                    else if (inputNum > 100)
                    {
                        Console.WriteLine(name + ", Please type a number less than 100.");
                        validInput = false;
                    }
                    else if (inputNum < 1)
                    {
                        Console.WriteLine(name + ", Please type a number greater than zero.");
                        validInput = false;
                    }
                    else
                    {
                        validInput = true;
                    }
                } while (!validInput);

                if (!((inputNum % 2) == 0))
                {
                    Console.WriteLine("Thank you, " + name);
                    Console.WriteLine("Your Output is the following: " + inputNum + " is an Odd number.");
                }
                else if (inputNum < 25)
                {
                    Console.WriteLine("Thank you, " + name);
                    Console.WriteLine("Your Output is the following: " + inputNum + " is Even and less than 25.");
                }
                else if (inputNum < 60)
                {
                    Console.WriteLine("Thank you, " + name);
                    Console.WriteLine("Your Output is the following: " + inputNum + " is Even and greater than 25.");
                }
                else
                {
                    Console.WriteLine("Thank you, " + name);
                    Console.WriteLine("Your Output is the following: " + inputNum + " is Even.");
                }

                bool correctRespone = true;
                while (correctRespone)
                {
                    Console.Write(name + ", will you continue the Usless Number Application? (y/n):");
                    input = Console.ReadLine().ToLower();
                    if (String.Equals("n", input))
                    {
                        again = false;
                        correctRespone = false;
                        Console.WriteLine("Goodbye " + name + ".");
                    }
                    else if (String.Equals("y", input))
                    {
                        Console.WriteLine("That is great news " + name + "! Starting Over.");
                        correctRespone = false;
                    }
                    else
                    {
                        Console.WriteLine(name + ", that is an invalid entry!");
                    }

                }
            }
        }
    }
}
