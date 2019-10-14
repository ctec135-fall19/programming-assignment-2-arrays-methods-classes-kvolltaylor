using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Student
    {
        // fields
        private string studentName;
        private int sid;

        // get method
        public string GetStudentName() { return studentName; }

        // set method
        public void SetStudentName(string name)
        {
            // perform validation
            studentName = name;
        }

        // properties
        public int studentID
        {
            get { return sid; }
            set
            {
                // perform validation ; throw exception
                if (value >= 100000 && value <= 999999)
                {
                    sid = value;
                }
                else
                {
                    //throw new System.ArgumentException();
                }
            }
        }

        // automatic properties
        public double GPA { get; set; }

        // master constructor with parameters for all 3 internal elements
        public Student(string name, int sid, double gpa)
        {
            studentName = name;
            studentID = sid;
            GPA = gpa;
        }

        // constructor using chaining
        public Student (string studentName, int sid) : this(studentName, sid, 0.0) { }

        // default constructor
        public Student() : this("none", 0, 0.0) { }

        // create a PrintState method
        public void PrintState()
        {
            //print the values to the screen
            Console.WriteLine("Name:\t" + studentName);
            Console.WriteLine("Student ID:\t" + studentID);
            Console.WriteLine("GPA:\t", GPA);
        }
    }
}
