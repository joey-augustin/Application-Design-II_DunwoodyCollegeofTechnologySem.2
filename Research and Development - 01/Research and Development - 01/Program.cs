using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Research_and_Development___01
{
    class User
    {
     //PRIVATE FIELDS
        private string name;
        private int age;
        private string hobby;


     //CONSTRUCTOR
        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


     //DISPLAY NAME AND AGE
        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + name + ", Age: " + age);
        }


     //DISPLAY NAME, AGE, AND HOBBY - OVERLOAD
        public void DisplayInfo(string hobby)
        {
            this.hobby = hobby;
            Console.WriteLine("Name: " + name + ", Age: " + age + ", Hobby: " + hobby);
        }


     //DISPLAY YEARS UNTIL RETIREMENT (65 Y/O)
        public void DisplayInfo(int yearsToRetirement)
        {
            Console.WriteLine(name + " will retire in " + yearsToRetirement + " years.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
     //ASK USER TO INPUT NAME, AGE, AND HOBBY
            Console.Write("Enter Your Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Hobby: ");
            string hobby = Console.ReadLine();


     //DISPLAY USER'S NAME AND AGE
            User user = new User(name, age);

            Console.WriteLine("Basic Info:");
            user.DisplayInfo();


     //DISPLAY USER'S NAME, AGE, AND HOBBY
            Console.WriteLine("Basic Info + Hobby:");
            user.DisplayInfo(hobby);


     //CALCULATE YEARS UNTIL RETIREMENT (65 Y/O)
            int retirementAge = 65;
            int yearsToRetirement = retirementAge - age;

            Console.WriteLine("Years Until Retirement:");
            user.DisplayInfo(yearsToRetirement);

            Console.ReadLine();
        }
    }
}
