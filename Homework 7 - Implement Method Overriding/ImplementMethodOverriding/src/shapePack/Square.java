package shapePack;

public class Square extends Rectangle {
    public void printSquare() 
    {
        System.out.println("This is Square. Subclass of Rectangle.");
    }
    
    
    // NEW - CALCULATE AREA
    @Override
    public void calculateArea(double length, double width) 
    {
    	if (length != width)
    	{
    		System.out.println("Error: For a square, length and width must be equal.");
    	}
    	 else
    	{
    	    double area = length * width;
    	    System.out.println("Area of Square: " + area);
    	}
    }
   
}