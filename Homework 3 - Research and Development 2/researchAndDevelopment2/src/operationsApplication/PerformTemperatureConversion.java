package operationsApplication;

import java.util.Scanner;
import operationsLibrary.TemperatureConverter;

public class PerformTemperatureConversion {

	public void start() {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Temperature Converter");
        System.out.println("1. Celsius to Fahrenheit");
        System.out.println("2. Fahrenheit to Celsius");
        System.out.print("Select an option (1 or 2): ");

        int choice = scanner.nextInt();

        if (choice == 1) {
            System.out.print("Enter temperature in Celsius: ");
            double celsius = scanner.nextDouble();

            double result = TemperatureConverter.celsiusToFahrenheit(celsius);
            System.out.println(celsius + " Celsius = " + result + " Fahrenheit");

        } else if (choice == 2) {
            System.out.print("Enter temperature in Fahrenheit: ");
            double fahrenheit = scanner.nextDouble();

            double result = TemperatureConverter.fahrenheitToCelsius(fahrenheit);
            System.out.println(fahrenheit + " Fahrenheit = " + result + " Celsius");

        } else {
            System.out.println("Invalid choice.");
        }

        scanner.close();
    }
}
