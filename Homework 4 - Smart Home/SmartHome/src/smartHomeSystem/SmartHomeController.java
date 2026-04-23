package smartHomeSystem;

import java.util.Scanner;

public class SmartHomeController {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        DeviceManager manager = new DeviceManager();

        System.out.print("How many devices do you want to add? ");
        int numDevices = scanner.nextInt();
        scanner.nextLine(); 

        for (int i = 0; i < numDevices; i++) {
            System.out.print("\nEnter device type (Light/Thermostat): ");
            String type = scanner.nextLine().trim().toLowerCase();

            switch (type) {

                case "light":
                    System.out.print("Enter device name: ");
                    String lightName = scanner.nextLine();

                    System.out.print("Enter brightness (0-100): ");
                    int brightness = scanner.nextInt();
                    scanner.nextLine(); 

                    System.out.print("Is it ON? (yes/no): ");
                    boolean lightStatus = scanner.nextLine().trim().equalsIgnoreCase("yes");

                    Light light = new Light(lightName, brightness, lightStatus);
                    manager.addDevice(light);

                    System.out.println("Device '" + lightName + "' added successfully!");
                    break;

                case "thermostat":
                    System.out.print("Enter device name: ");
                    String thermoName = scanner.nextLine();

                    System.out.print("Enter temperature (°F): ");
                    double temperature = scanner.nextDouble();
                    scanner.nextLine(); 

                    System.out.print("Is it ON? (yes/no): ");
                    boolean thermoStatus = scanner.nextLine().trim().equalsIgnoreCase("yes");

                    Thermostat thermostat = new Thermostat(thermoName, temperature, thermoStatus);
                    manager.addDevice(thermostat);

                    System.out.println("Device '" + thermoName + "' added successfully!");
                    break;

                default:
                    System.out.println("Invalid device type. Skipping...");
            }
        }

        manager.displayAllDevices();
        scanner.close();
    }
}