using System;
using System.Collections.Generic;
using System.Linq;


namespace Tema4
{
    class Program
    {
        static void Main(string[] args)
        {
            //## Conditionals
            //EXERCISE1
            /* Write a program and ask the user to enter a number.
             The number should be between 1 to 10. If the user enters 
             a valid number, display "Valid" on the console. 
             Otherwise, display "Invalid". (This logic is used a lot in 
             applications where values entered into input boxes need to be validated.)*/
            /*while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number >= 1 && number <= 10)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }*/



            //EXERCISE2
            // Write a program which takes two numbers from the console and displays the maximum of the two.
            /*int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("The maximum:" +number1);
            }
            else
            {
                Console.WriteLine("The maximum:" +number2);
            }
            */



            /*Your job is to write a program for a speed camera.For simplicity, ignore the details such as camera, sensors,
            etc and focus purely on the logic.Write a program that asks the user to enter the speed limit.Once set,
            the program asks for the speed of a car.If the user enters a value less than the speed limit, program should
            display Ok on the console.If the value is above the speed limit, the program should calculate the number of
            penalty points.For every 5km / hr above the speed limit, 1 penalty point should be incurred and displayed on
            the console.If the number of penalty points is above 12, the program should display License Suspended.*/


            /* Console.WriteLine("Speed limit: ");
             int speedLimit = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Speed of a car: ");
             int speedCar = Convert.ToInt32(Console.ReadLine());
             int penaltyPoints = 0;
             int dif = speedCar - speedLimit;

             if(speedCar < speedLimit)
             {
                 Console.WriteLine("OK");
             }
             else if(speedCar > speedLimit)
             {
                 for (int i = 5; i <= dif; i++)
                 {
                     penaltyPoints = dif / 5;
                 }
             }
             Console.WriteLine("Pentalty Points " +penaltyPoints);
             if(penaltyPoints > 12 )
             {
                 Console.WriteLine("License Suspended");
             }
             */




            //## Lists

            /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
            /// Display the reversed name on the console.
            /// 
            /*string name=Console.ReadLine();
            var newString = "";
            for (var i = name.Length - 1; i >= 0; i--)
            {
                newString += name[i];
            }

            Console.WriteLine(newString);
            */


            /// Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display
            /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
            /// and display the result on the console.


            /*var number = new int[5];
            Console.WriteLine("Enter 5 unique numbers");
           for (int i = 0; i < 5; i++)
             {
                while (true)
                 {
                  var newValue = Convert.ToInt32(Console.ReadLine());
                  var currentNumber = Array.IndexOf(number, newValue);
                  if (currentNumber == -1)
                      {
                         number[i] = newValue; // Accept New value
                         break;
                       }
                 Console.WriteLine("Hold on, you already entered that number. Try again.");
                    }


                  Array.Sort(number);
                  Console.WriteLine();
             */


            /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
            /// include duplicates. Display the unique numbers that the user has entered.


            /* while(true)
             {
                 var number = Console.ReadLine();
                 if (number == "Quit")
                 {
                     break;
                 }
             }*/


            ///Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10).If the list is
            /// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
            /// the 3 smallest numbers in the list.


            /* string[] elements;
             while (true)
             {
                 Console.Write("Enter a list of numbers: ");
                 var input = Console.ReadLine();
                 elements = input.Split(',');
                 if (elements.Length <= 5)
                     Console.WriteLine("Invalid List");

             }

         }*/




            //## Loops
            //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the result on the console.
            /* int count = 0;
             for(int i=1;i<=100;i++)
             {
                 if(i%3==0)
                 {
                     count++;
                 }
             }
             Console.WriteLine(count);*/




            // Write a program and continuously ask the user to enter a number. The loop terminates when the user enters “ok". Calculate the sum of all the previously entered numbers and display it on the console.
            /* var sum = 0;
             while (true)
             {
                 Console.Write("Enter a number: ");
                 var input = Console.ReadLine();
                 int newVariable = 0;
                 if (input != "ok")
                 {
                     sum++;
                 }
                 else if (input == "ok")
                 {
                     break;
                 }
             }
             Console.WriteLine("Sum is: " + sum);*/



            /* Write a program which takes a single number from the user,
             calculates the factorial and prints the value on the console.
             For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
             and display it as 5! = 120(result of 5 x 4 x 3 x 2 x 1).*/

            /*int i, fact = 1;
            int number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
            */




            /* Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.
              If the user guesses the number, display “You won". Otherwise, display “You lost".*/
            /*  var number = new Random().Next(1,10);
              for(int i=0;i<=4;i++)
              {
                  int nr= Convert.ToInt32(Console.ReadLine());
                  if (nr == number)
                      Console.WriteLine("You won");
                  else
                      Console.WriteLine("You lost");

              }*/

            /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            /// numbers and display it on the result. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            /// display 8 on the console.
            /// 

            /*var name = Console.ReadLine();
            var numarray = name.Split(',');
            Console.WriteLine(numarray.Max());
            */






            //## Strings


            //Write a program and ask the user to enter a few numbers separated by a hyphen(minus).
            //Work out  if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
            //display a message: "Consecutive"; otherwise, display "Not Consecutive".
            /* var name = Console.ReadLine();
             var numarray = name.Split('-');
             int firstValue = Convert.ToInt32(numarray[0]);
             for (var i = 0; i < numarray.Length; i++)
             {
                 if (Convert.ToInt32(numarray[i]) - i != firstValue)
                 {
                     Console.WriteLine("not Consecutive");
                     break;
                 }
                 else
                     Console.WriteLine("consecutive");
             }*/




            /// Write a program and ask the user to enter a few numbers separated by a hyphen(minus). If the user simply 
            /// presses Enter without supplying an input, exit immediately; otherwise, check to see if there are 
            /// any duplicates. If so, display "Duplicate" on the console.
            /// 

            var name = Console.ReadLine();
            var numarray = name.Split('-');
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

            if (consoleKeyInfo.Key == ConsoleKey.Enter)
                Environment.Exit(0);



            /*Write a program and ask the user to enter an English word. Count the number of vowels
            (a, e, o, u, i) in the word. So, if the user enters "inadequate", the program should display 
            6 on the console. Make sure the program calculates the number of vowels irrespective of the 
            casing of the word (eg "Inadequate", "inadequate" and "INADEQUATE" all include 6 vowels).*/

            /*var word = Console.ReadLine().ToLower();
            var vowels = new char[] { 'a', 'e', 'o', 'u', 'i' };
            var vowelsCount = 0;
            foreach (var character in word)
            {
                if (vowels.Contains(character))
                    vowelsCount++;
            }
            Console.WriteLine(vowelsCount);*/
        }
    }
}

