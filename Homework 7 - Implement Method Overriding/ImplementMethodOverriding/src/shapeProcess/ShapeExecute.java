package shapeProcess;

import shapePack.Square;

import java.util.Scanner;

import shapePack.Rectangle;
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
        
        
        //====================
        //NEW - CALCULATE AREA
        //====================
       
        //SQUARE - INPUT
        Scanner sc = new Scanner(System.in);
        
        System.out.println("Area of Square:");
        
        System.out.print("Enter length for square: ");
        double sqLength = sc.nextDouble();
        
        System.out.print("Enter width for square: ");
        double sqWidth = sc.nextDouble();
        
        System.out.println();
        
        //RECTANGLE - INPUT
        System.out.println("Area of Rectangle:");
        
        System.out.print("Enter length for rectangle: ");
        double rectLength = sc.nextDouble();
        
        System.out.print("Enter width for rectangle: ");
        double rectWidth = sc.nextDouble();
        
        System.out.println();
        
        Rectangle rectangle = new Rectangle();
        
        //AREA - OUTPUT
        System.out.println("RESULT: ");
        square.calculateArea(sqLength, sqWidth);
        
        System.out.println();
        
        System.out.println("RESULT: ");
        rectangle.calculateArea(rectLength, rectWidth);
        
        sc.close();
        
        System.out.println();
        System.out.println("-----");
        System.out.println();
        
        
        // Using SemiCircle object
        semicircle.printShape();
        semicircle.printCircle();
        semicircle.printSemiCircle();
        
        System.out.println();
        
    }
}