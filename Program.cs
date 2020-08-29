using System;

namespace c_grade_translator_assignment_AlecTech
{
    class Program
    {
        static void Main(string[] args)
        {
            // Author Oleg Eremeev
            // Date: 2020 11 Aug
            //Purpose: app will read input from console numeric value and compare 
            //with list of corresponding alphabetic charecters and output the match 
            Console.WriteLine("Please enter your Score from 0-100");
            string input = Console.ReadLine();


            int numInput = Int32.Parse(input);


            if (numInput > 0 && numInput <= 49)
            {
                Console.WriteLine("Your grade is F");
                // Do the option 1 stuff.
            }
            else if (numInput >=50 && numInput <=54)
            {
                Console.WriteLine("Your grade is D");
                // Do the option 2 stuff.
            }
            else if (numInput >=55 && numInput <=59)
            {
                Console.WriteLine("Your grade is C-");
                // Do the option 1 stuff.
            }
            else if (numInput >=60 && numInput <=64)
            {
                Console.WriteLine("Your grade is C");
                // Do the option 1 stuff.
            }
            else if (numInput >=65 && numInput <=69)
            {
                Console.WriteLine("Your grade is C+");
                // Do the option 1 stuff.
            }
            else if (numInput >=70 && numInput <=74)
            {
                Console.WriteLine("Your grade is B-");
                // Do the option 1 stuff.
            }
            else if (numInput >=75 && numInput <=79)
            {
                Console.WriteLine("Your grade is B");
                // Do the option 1 stuff.
            }
            else if (numInput >=80 && numInput <=84)
            {
                Console.WriteLine("Your grade is B+");
                // Do the option 1 stuff.
            }
            else if (numInput >=85 && numInput <=89)
            {
                Console.WriteLine("Your grade is A-");
                // Do the option 1 stuff.
            }
            else if (numInput >=90 && numInput <=96)
            {
                Console.WriteLine("Your grade is A");
                // Do the option 1 stuff.
            }
            else if (numInput >=97 && numInput <=100)
            {
                Console.WriteLine("Your grade is A+");
                // Do the option 1 stuff.
            }

            else
            {
                Console.WriteLine("Invalid entry");
                // Invalid menu choice.
            }





                             //int numInput = -1;
            
                             /* while (numInput != 0)
                            {
                                 Console.WriteLine("Grade\n------\n1. Option 1\n2. Option 2\n3. Option 3\n4. Option 4\n0. Exit");

                                  Console.Write("Please enter a menu option:");
                                 numInput = int.Parse(Console.ReadLine());

                                 switch (numInput)
                                  {
                                      case 1:
                                       case 2:
                                          case 3:
                                              case 4:
                                         Console.WriteLine("Running option {0}.", numInput);
                                          break;
                                      default:
                                            Console.WriteLine("Not a valid menu option.");
                                          break;
                                     }



                             } */
        }
    }
}
