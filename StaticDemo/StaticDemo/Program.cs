using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    class Student
    {
        // fields
        private string name;
        private int rno;
        private float marks;
        private char grade;
        private string comments;

        // properties
        public string AutoComment
        {
            get
            {
                return comments;
            }
            set
            {
                if (value != "") comments = value;
                else comments = "You did pretty well this time, but there's still scope for improvements.";
            }
        }

        // methods
        public void PrintResult()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll no: " + rno);
            Console.WriteLine("Marks Obtained: " + marks);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Comments: " + comments);
            Console.WriteLine("---------------------------");
        }

        // constructors
        public Student(string name, int rno, float marks)
        {
            this.name = name;
            this.rno = rno;
            this.marks = marks;

            if (marks <= 100 && marks > 90) grade = 'A';
            else if (marks <= 90 && marks > 80) grade = 'B';
            else if (marks <= 80 && marks > 70) grade = 'C';
            else if (marks <= 70 && marks > 60) grade = 'D';
            else if (marks <= 60 && marks > 50) grade = 'E';
            else if (marks <= 50 && marks > 0) grade = 'F';
            else grade = 'X';
        }

        // overriding ToString()
        public override string ToString()
        {
            return "\tname: " + name + "\n\trno: "+ rno +"\n\tmarks: "+marks+"\n\tgrade: "+grade+"\n\tcomments: "+comments;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Chahat", 32, 95.5f);
            s1.AutoComment = "WOW!! Great performance";
            s1.PrintResult();

            Student s2 = new Student("Kalsi", 64, 72f);
            s2.AutoComment = "";
            s2.PrintResult();

            Console.WriteLine(s1.ToString());

            Console.Read();
        }
    }
}
