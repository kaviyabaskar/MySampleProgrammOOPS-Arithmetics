using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MySampleProgrammOOPS
{
    class Book
    {
        //Methods
        public void IssueBook()
        {
            Console.WriteLine("Book Issued");

        }
    }
        internal class Student
        {
            //Properties
            public int StudentID;
            public string StudentName;
            private int age;
            //Methods
            public void checkEligibility(int a)
            
            {
                age = a;
                if (a > 18)
                {
                    Console.WriteLine("Eligible");
                }
               else
                {
                    Console.WriteLine("Not Eliogible");
                }
            }
            public void AddStudents()
            {
                Console.WriteLine("Enter Student Information");
                Console.WriteLine("Enter STudent ID -");
                StudentID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the students name");
                StudentName = Console.ReadLine();
                Console.WriteLine("Student Added");
                 Book b1 = new Book();
                b1.IssueBook();
            }
            public void DisplayStudentDetails()
            {
                Console.WriteLine($"{StudentID} and name is {StudentName}");
            }
        }
    }
    
    

