package researchAndDevelopment01;

import java.util.Scanner;

class User
{
	//PRIVATE FIELDS
		private String name;
		private int age;
		private String hobby;
		
		
	//CONSTRUCTOR
		public User(String name, int age)
		{
	        this.name = name;
	        this.age = age;
		}
		
		
	//DISPLAY NAME AND AGE
		public void displayInfo() 
		{
	        System.out.println("Name: " + name + ", Age: " + age);
		}
		
		
	//DISPLAY NAME, AGE, AND HOBBY - OVERLOAD
		public void displayInfo(String hobby) 
		{
	        this.hobby = hobby;
	        System.out.println("Name: " + name + ", Age: " + age + ", Hobby: " + hobby);
	    }
		
		
	//DISPLAY YEARS UNTIL RETIREMENT (65 Y/O)
		 public void displayInfo(int yearsToRetirement) 
		 {
		        System.out.println(name + " will retire in " + yearsToRetirement + " years.");
		 }
}


public class Main
{
	public static void main(String[] args)
	{
		Scanner scanner = new Scanner(System.in);
			
		
	//ASK USER TO INPUT NAME, AGE, AND HOBBY
		 System.out.print("Enter Your Name: ");
	     String name = scanner.nextLine();

	     System.out.print("Enter Your Age: ");
	     int age = scanner.nextInt();
	     scanner.nextLine();

	     System.out.print("Enter Your Hobby: ");
	     String hobby = scanner.nextLine();
		
		
	//DISPLAY USER'S NAME AND AGE
		User user = new User(name, age);
		
		System.out.println("Basic Info:");
		user.displayInfo();
		
		
	//DISPLAY USER'S NAME, AND, AND HOBBY
		System.out.println("Basic Info + Hobby:");
        user.displayInfo(hobby);
		
		
	//CALCULATE YEARS UNTIL RETIREMENT (65 Y/O)
        int retirementAge = 65;
        int yearsToRetirement = retirementAge - age;

        System.out.println("Years Until Retirement:");
        user.displayInfo(yearsToRetirement);

        scanner.close();
	}
}