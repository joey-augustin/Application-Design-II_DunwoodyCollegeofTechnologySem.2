package abstraction3;

import java.util.Scanner;

public class Utility {

    Scanner scanner = new Scanner(System.in);


    String checkForName(String animalType) {
        System.out.print("Do you have a name for the " + animalType + "? (Y/N): ");
        String response = scanner.nextLine().trim().toLowerCase();

        if (response.equals("y")) {
            System.out.print("Enter the name for the " + animalType + ": ");
            String name = scanner.nextLine().trim();
            return name;
        }
        return null;
    }

    Lion getLionObject(String lionName) {
        if (lionName == null) {
            return new Lion();
        } else {
            return new Lion(lionName);
        }
    }

    Giraffe getGiraffeObject(String giraffeName) {
        if (giraffeName == null) {
            return new Giraffe();
        } else {
            return new Giraffe(giraffeName);
        }
    }

    Bear getBearObject(String bearName) {
        if (bearName == null) {
            return new Bear();
        } else {
            return new Bear(bearName);
        }
    }
}