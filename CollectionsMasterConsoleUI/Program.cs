﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq.Expressions;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

        //TODO: Follow the steps provided in the comments under each region.
        //Make the console formatted to display each section well
        //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

        #region Arrays
        //TODO: Create an integer Array of size 50
            int[] numbers = new int[50];
            Populater(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            Console.WriteLine("First number");
            Console.WriteLine(numbers[0]);
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Console.WriteLine();
            Console.WriteLine("Last number");
            //TODO: Print the first number of the array
            Console.WriteLine(numbers[49]);
            Console.WriteLine();
            //TODO: Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbers);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");
            ReverseArray(numbers);

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbers);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbers);
            NumberPrinter(numbers);



            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            List<int> list = new List<int>();
           Console.WriteLine(list.Capacity);
            NumberPrinter(list);
            Console.WriteLine();
          ////TODO: Print the capacity of the list to the console
            
           

            ////TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(list);
            NumberPrinter(list);


            //TODO: Print the new capacity
            Console.WriteLine("new capacity");
            Console.WriteLine(list.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            string user = Console.ReadLine();

            if (int.TryParse(user, out int userNumber))
            {
                NumberChecker(list, userNumber);
            }
            
           
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
           NumberPrinter(list);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
           OddKiller(list);
           

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            list.Sort();
            NumberPrinter(list);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            int[] newArray = list.ToArray();
            foreach(int num in newArray)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Clear List");
            //TODO: Clear the list
            Array.Clear(newArray, 0, newArray.Length);
            NumberPrinter(newArray);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }

                Console.WriteLine(numbers[i]);
            }


        }

        private static void OddKiller(List<int> numberList)
        {

            foreach (int num in numberList)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                    
                }
               
            }
            

            
            

               
            
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
          if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"the number {searchNumber} is in the list");
            }
          else
            {
                Console.WriteLine($"the number {searchNumber} is not in the list");
            }
            
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            
            for (int i = 0; i < 51; i++)
            {
                
                numberList.Add(rng.Next(0,51));
                
            }
           
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0,51);
            }




        }

        private static void ReverseArray(int[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
