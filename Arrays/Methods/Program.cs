/* 
Author: Katrina Voll-Taylor
Date: 14 October 2019
CTEC 135: Microsoft Software Development with C# 

Module 3, Programming Assignment 2, Problem 2

    Prob 2: Methods
        - Create a project for this problem
        - Create a static method that demonstrates call by value. 
          Add print statements that will help demonstrate this concept.
        - Create a static method that demonstrates call by reference. Add print statements that will help demonstrate this concept.
        - Create static methods that demonstrate method overloading

        In Main() create the following
            region 1: demo of call by value
                - Code that will demonstrate call by value
            region 2: demo of call by reference
                - code that will demonstrate call by reference
            region 3: overloading
                - code that demonstrates method overloading

 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region region 1: demo of call by value
            // Input: an int
            // Process: send as a parameter to a method
            // Output: that same int after it has been passed to the method

            Console.WriteLine("Region 1: Demo of Call by Value");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 35)));


            // declare and initialize int
            int myInteger = 101;

            // show value before method is called
            Console.WriteLine("Value of myInteger before call: " + myInteger);
            Console.WriteLine();

            // call method
            CallByValue(myInteger);

            // show value after method is called
            Console.WriteLine("Value of myInteger after call: " + myInteger);
            Console.WriteLine("\n");

            #endregion

            #region Region 2: demo of call by reference
            // Input: array of strings
            // Process: send as a parameter to a method
            // Output: that same string after it has been passed to the method

            Console.WriteLine("Region 2: Demo of Call by Reference");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 35)));

            // declare and intialize array of strings
            string[] myStrings = new string[] { "Teeny", "Weeny", "Beany" };

            // show value before method is called
            Console.Write("Value of myString before call: ");
            foreach (string item in myStrings)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // call method
            CallByRef(myStrings);

            // show value after method is called
            Console.Write("Value of myString after call: ");
            foreach (string item in myStrings)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n");

            #endregion

            #region Region 3: Overloading
            // Input: objects of two different data types
            // Process: send as parameters to a method
            // Output: same objects after they have been passed to the method

            Console.WriteLine("Region 3: Demo of Overloading");
            Console.WriteLine(string.Concat(Enumerable.Repeat("-", 35)));

            // declare and intialize array of ints
            int[] myInts = new int[] { 21, 99, 843, 3 };

            //show values before method is called
            Console.Write("Value of myStrings before call: ");
            foreach (string item in myStrings)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n" + "Value of myInts before call: " );
            foreach (int item in myInts)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            //call method
            Overload(myStrings);
            Overload(myInts);

            Console.WriteLine();

            // show values after method is called
            Console.Write("Value of myStrings after call: ");
            foreach (string item in myStrings)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Value of myInts after call: ");
            foreach (int item in myInts)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            #endregion

        }

        // method to demonstrate call by value
        static void CallByValue(int methodValue)
        {
            methodValue = 24;
            // show value of int while method is called
            Console.WriteLine("Value of int methodValue when myInteger is passed in" +
                " while method is being called: " + methodValue);
            Console.WriteLine();
        }

        // method to demonstrate call by reference
        static void CallByRef(string[] methodRef)
        {
            methodRef[0] = "Snap";
            methodRef[1] = "Crackle";
            methodRef[2] = "Pop";

            // show value of string while method is called
            Console.WriteLine("Value of strings in methodRef when myStrings is passed in" +
                " while method is being called: " + methodRef[0] + " " + methodRef[1] 
                + " " + methodRef[2]);
            Console.WriteLine();
        }

        // methods to demonstrate overloading
        static void Overload(string[] methodOverload)
        {
            methodOverload[0] = "Bell";
            methodOverload[1] = "Book";
            methodOverload[2] = "Candle";

            Console.WriteLine("Value of strings in methodOverload when myStrings is passed in" +
                " while method is being called: " + methodOverload[0] + " " + methodOverload[1]
                + " " + methodOverload[2]);
        }
        static void Overload(int[] methodOverload)
        {
            methodOverload[0] = 12;
            methodOverload[1] = 123;
            methodOverload[2] = 1235;
            methodOverload[3] = 12358;

            Console.WriteLine("Value of ints in methodOverload when myInts is passed in" +
                " while method is being called: " + methodOverload[0] + " " + methodOverload[1]
                + " " + methodOverload[2]);
        }
    }
}
