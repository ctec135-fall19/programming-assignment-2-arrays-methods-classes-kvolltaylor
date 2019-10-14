/* 
Author: Katrina Voll-Taylor
Date: 14 October 2019
CTEC 135: Microsoft Software Development with C# 

Module 3, Programming Assignment 2, Problem 3

    Prob 3: Class
        - Create a project for this problem
        - Create a "Student" class:
            - create a name field and the associated set and get methods
            - create a ID property. Add validation code to the set method 
              that ensures the value is between 100000 and 999999. Throw an exception 
              if the value is out of range.
            - create an automatic property for GPA. Pick an appropriate type.
            - create a master constructor that has parameters for all three internal
              data elements
            - create a constructor that has parameters for name and ID and uses chaining
            - create a default constructor
            - code a "PrintState()" method
        - In Main() demonstrate:
            - the use of each constructor. Print the state as necessary to show 
              behavior.
            - the use of the accessor and mutator for the name field
            - the use of the both properties
            - a try/catch block that demonstrates the exception that was coded 
              into the ID property
use regions as you think appropriate.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {

            // Input: field data when needed to create new objects
            // Process: Student class constructors and methods are called
            // Output: Data from fields of each Student class object

            // use PrintState method to print constructor types

            // default example
            Student ralph = new Student ();
            ralph.PrintState();
            Console.WriteLine();

            // chaining example
            Student harvey = new Student ("Harvey", 111111);
            harvey.PrintState();
            Console.WriteLine();

            // master example
            Student fred = new Student("Fred", 333333, 4.5);
            fred.PrintState();
            Console.WriteLine();

            // Accessor and Mutator Use

            // show accessor use
            Console.WriteLine("Using accessor for student name: " 
                + harvey.GetStudentName());
            // show mutator use
            harvey.SetStudentName("Harverino");
            Console.WriteLine("After using mutator for student name: "
                + harvey.GetStudentName());
            Console.WriteLine();


            // show try/catch
            //try
            //{
            //    fred.studentID = 1333999999;
            //}
            //catch (System.ArgumentException example)
            //{
            //    System.ArgumentException argExample = new System.ArgumentException("Invalid Student Id Number", example);
            //    throw argExample;
            //}
            //finally
            //{
            //    fred.studentID = 0;
            //}

        }
    }
}
