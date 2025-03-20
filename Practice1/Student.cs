using System;


namespace Practice1
{
    internal class Student
    {
        int rollno;
        string name;
        float marks;
        double per;

        public void acceptData()
        {

            Console.WriteLine("Enter rollno: ");
            rollno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter marks : ");
            marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Percentage : ");
            per = Convert.ToInt32(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine("Student Roll no : " + rollno);
            Console.WriteLine("Student name : " + name);
            Console.WriteLine("Student marks : " + marks);
            Console.WriteLine("Student Percentage : " + per);
        }
    }
}
