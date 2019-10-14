/* 
Author: Katrina Voll-Taylor
Date: 14 October 2019
CTEC 135: Microsoft Software Development with C# 

Module 3, Programming Assignment 2, Problem 1

    Prob 1: Arrays
        Create a project for this problem
            NOTE: DO NOT use literal size values in your loops 
            - use the array length property
        In Main() create the following
        
        region 1: array of strings
            - create an array of strings of the first ten whole numbers 
            (e.g. "one", "two", . . . "ten")
            - Initialize the array using initialization syntax
            - print the array using a foreach loop

        region 2: array of ints
            - create an array of ints of size 10
            - Initialize the array using a for loop with values being 
            the index multiplied by 10
            - print the array using a for loop

        region 3: 2-D array
            - create a 2-D array that will hold the values of the 
            multiplication table up to 12 x 12
            - Initialize the array
            - print the array in a well formatted manner
            - bonus points for labeling the rows and columns

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Region 1:
            // Input: array of strings
            // Process: iterate through each element using a foreach loop
            // Output: print each of the elements to the console

            Console.WriteLine("Region 1:" + "\n----------");

            // declare and initialize array of strings
            string[] arrStringNumbers = { "one", "two", "three","four","five",
                "six","seven","eight","nine","ten"};

            // use foreach loop to print each array element to the console
            foreach (string item in arrStringNumbers)
            {
                Console.Write(item + "  ");
            }
            
            Console.WriteLine("\n");
            #endregion

            #region Region 2:
            // Input: array of 10 integers
            // Process: iterate through each element multiplied by 10 
            // using a for loop
            // Output: print each of the elements to the console

            Console.WriteLine("Region 2:" + "\n----------");

            // declare array
            int[] arrInts = new int[10];

            // intialize array using for loop 
            // each iteration the value of the previous element 
            // created must be multiplied by 10 
            for (int i = 0; i < arrInts.Length; i++)
            {
                arrInts[i] = (i * 10);
                Console.WriteLine(arrInts[i]);
            }

            Console.WriteLine("\n");
            #endregion

            #region Region 3:
            // Input: 2D array of multiplication table to 12*12
            // Process:
            // Output: print array in an orderly grid

            Console.WriteLine("Region 3:" + "\n----------");

            // declare array
            int[,] multiplicationTable = new int[12,12];

            // declare and intialize product value for table content
            int product = 0;
            
            // write top row label for multiplication table
            for (int l = 0; l <= 12; l++)
            {
                Console.Write("| ");
                // change text color of l
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(l + "\t");
                // change the color back to default
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine();

            // write a line underneath each product
            for (int m = 0; m <= 12; m++)
            {
                Console.Write("_____" + "\t");
            }

            Console.WriteLine("\n");

            Console.WriteLine();

            // initialize array using nested loops
            for (int i = 1; i <= 12; i++)
            {
                // change text color of i
                Console.Write("| ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(i + "\t");
                // change text color back to default
                Console.ForegroundColor = ConsoleColor.Gray;

                for (int j = 1; j <= 12; j++)
                {
                    // find product of indexes
                    product = (i * j);
                    Console.Write("| ");
                    // change text color of the product
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(product + "\t");
                    // change the color back to default
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine();
                
                // write a line underneath each product
                for(int k = 0; k <= 12; k++)
                {
                    Console.Write("_____" + "\t");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine();
            #endregion
        }
    }
}
