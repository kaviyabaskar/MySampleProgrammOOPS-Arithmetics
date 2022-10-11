//using System;



//namespace MySampleProgrammOOPS
//{
//    //OOPs Concept 1. Classes Objects
//    class Employee
//    {
//        //properties - data value variable
//        //predefined values
//        //string Designation="Manager";
//        //methods
//        int EmpID;
//        String EmpName;
//        String Designation;

//        public void getEmployeeInformation()
//        {

//            Console.WriteLine("Enter Your Id");
//            EmpID = Convert.ToInt32(Console.ReadLine());//use to read the input screen
//            Console.WriteLine($"Your Id is {EmpID}");

//            Console.WriteLine("Enter Your EmpName");
//            EmpName = Console.ReadLine();//use to read the input screen
//            Console.WriteLine($"Your Name is {EmpName}");


//            Console.WriteLine("Enter Your Designation");
//            Designation = Console.ReadLine();//use to read the input screen
//            Console.WriteLine($"Your Designation is {Designation}");
//        }


//        public void DisplayEmployeeInformation()
//        {
//            Console.WriteLine($"Empid -{EmpID} EmpName is -{EmpName} Empdesignation - {Designation}");
//        }
//        public static void Main()
//        {
//            Console.WriteLine("OOPs Concepts");
//            Employee emp = new Employee(); //declartion of an abject
//            emp.getEmployeeInformation();
//            emp.DisplayEmployeeInformation();
//            Console.ReadKey();

//        }
//    }
//}



//       /* class Program

//    {
//        //entry point of application
//        public static void main()
//        {
//            Console.WriteLine("OOPs Concepts");
//            Employee emp = new Employee(); //declartion of an abject
//            emp.getEmployeeInformation();
//            emp.DisplayEmployeeInformation();
//            //Get values from user

//            //Console.ReadKey();


//        }

//    }

//using System;
//namespace MySampleProgrammOOPS
//{
//    class Program
//    {
//        //entry point of application
//        public static void Main()
//        {
//            Student std1 = new Student();

//            std1.AddStudents();
//            Student std2 = new Student();
//            std2.AddStudents();
//            Student std3 = new Student();
//            std3.AddStudents();
//            Console.Clear(); //it will clear the commands in console screen
//            Console.WriteLine("*******************");
//            std1.DisplayStudentDetails();
//            std2.DisplayStudentDetails();
//            std3.DisplayStudentDetails();


//            //check student eligible 
//            std1.checkEligibility(20);

//        }
//    }
//}

using System;
namespace MySampleProgrammOOPS
{
    class Program
    {
        //entry point of applicaation
        public static void Main()
        {
            Product pro = new Product();
            pro.AddProducts();
            pro.DisplayProductDetails();
            Console.ReadKey();
        }
    }
}
