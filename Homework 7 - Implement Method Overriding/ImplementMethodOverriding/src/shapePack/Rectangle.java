package shapePack;

public class Rectangle extends Shape {
    public void printRectangle() 
    {
        System.out.println("This is Rectangle. Subclass of Shape.");
    }
    
    
    // NEW - CALCULATE AREA
    public void calculateArea(double length, double width)
    {
    	double area = length * width;
    	System.out.println("Area of Rectangle: " + area);
    }
}