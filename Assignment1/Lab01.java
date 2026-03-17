package LabPackage;

import java.util.Scanner;

public class Lab01 {

	public static void main(String[] args)
	{
	//TASK 1 - OUTPUT STATEMENTS
       
		System.out.println("Hello, my name is Joey.");
        System.out.println("My favorite color is yellow.");
        System.out.println("The current year is 2026.");

        System.out.println("            ");
        System.out.println("--------------------------------------------------------------------------");
        System.out.println("             ");
		
        
	//TASK 3 - VARIABLES
       
        Scanner scanner = new Scanner(System.in);
        
        //WHOLE NUMBER INTEGER VALUE FOR AGE
        System.out.print("Enter your age: ");
        int age = scanner.nextInt();

        //DECIMAL VALUE FOR HEIGHT
        System.out.print("Enter your height in meters: ");
        double height = scanner.nextDouble(); 
         
        //CHARACTER VALUE FOR LETTER
        System.out.print("Enter your favorite letter: ");
        char letter = scanner.next().charAt(0);

        //BOOLEAN VALUE FOR TRUE/FALSE STATEMENT
        System.out.print("You like Programming? (true/false): ");
        boolean programming = scanner.nextBoolean();

        System.out.println("       ");
        System.out.println("I am " + age + " years young!");
        System.out.println("I am " + height + " meters tall!");
        System.out.println("My favorite letter is " + letter + "!");
        System.out.println("It is " + programming + " that I like programming!");


        System.out.println("            ");
        System.out.println("--------------------------------------------------------------------------");
        System.out.println("             ");
		
        
	/*TASK 4 -
	CONSTANTS*/
      
        //CREATING THE EQUATION FOR AREA OF A CIRCLE
        double PI = 3.14159;
        double radius = 5;

        double area = PI * radius * radius;  

        System.out.println("The area of the circle is " + area);

        System.out.println("            ");
        System.out.println("--------------------------------------------------------------------------");
        System.out.println("             ");
		
	//TASK 5 - DATA TYPES
        
        //DETERMINING DIFFERENT DATA TYPES
        String FirstName = "Sarah";    
        long population = 1500000;
        double temperature = 23.5;
        boolean student = true;

        System.out.println("Ther person's name is " + FirstName + ".");
        System.out.println("The population of the city is " + population + ".");
        System.out.println("The temperature is " + temperature + " degrees Celcius.");
        System.out.println("Is the person a student? " + student);
		
	}
}
