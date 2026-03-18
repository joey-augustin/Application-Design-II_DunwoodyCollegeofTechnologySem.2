using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //TASK 1 - OUTPUT STATEMENTS

            Console.WriteLine("Hello, my name is Joey.");
            Console.WriteLine("My favorite color is yellow.");
            Console.WriteLine("The current year is 2026.");


            Console.WriteLine("            ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("             ");



        //TASK 3 - VARIABLES

            //WHOLE NUMBER INTEGER VALUE FOR AGE
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine()); 

            //DECIMAL VALUE FOR HEIGHT
            Console.Write("Enter your height in meters: ");
            double height = Convert.ToDouble(Console.ReadLine());  
             
            //CHARACTER VALUE FOR LETTER
            Console.Write("Enter your favorite letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            //BOOLEAN VALUE FOR TRUE/FALSE STATEMENT
            Console.Write("You like Programming? (true/false): ");
            bool programming = Convert.ToBoolean(Console.ReadLine()); 

            Console.WriteLine("       ");
            Console.WriteLine("I am " + age + " years young!");
            Console.WriteLine("I am " + height + " meters tall!");
            Console.WriteLine("My favorite letter is " + letter + "!");
            Console.WriteLine("It is " + programming + " that I like programming!");


            Console.WriteLine("            ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("             ");



        /* TASK 4 -
         * CONSTANTS */

            //CREATING THE EQUATION FOR AREA OF A CIRCLE
            const double PI = 3.14159;
            double radius = 5;

            double area = PI * radius * radius;  

            Console.WriteLine("The area of the circle is " + area);

            Console.WriteLine("            ");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("             ");



        //TASK 5 - DATA TYPES

            //DETERMINING DIFFERENT DATA TYPES
            string FirstName = "Sarah";    
            long population = 1500000;
            double temperature = 23.5;
            bool student = true;

            Console.WriteLine("Ther person's name is " + FirstName + ".");
            Console.WriteLine("The population of the city is " + population + ".");
            Console.WriteLine("The temperature is " + temperature + " degrees Celcius.");
            Console.WriteLine("Is the person a student? " + student);



           Console.ReadKey();
        }
    }
}
