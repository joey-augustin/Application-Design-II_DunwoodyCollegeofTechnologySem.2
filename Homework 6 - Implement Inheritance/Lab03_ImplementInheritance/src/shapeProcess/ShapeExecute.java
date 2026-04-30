package shapeProcess;

import shapePack.Square;
import shapePack.SemiCircle;

public class ShapeExecute {
    public static void main(String[] args) 
    {
        // Create 2 objects
        Square square = new Square();
        SemiCircle semicircle = new SemiCircle();

        // Using Square object
        square.printShape();
        square.printRectangle();
        square.printSquare();

        System.out.println();

        // Using SemiCircle object
        semicircle.printShape();
        semicircle.printCircle();
        semicircle.printSemiCircle();
    }
}