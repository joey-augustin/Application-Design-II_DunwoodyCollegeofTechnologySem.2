//EXPLANATION OF CHANGES IN "PACKAGE-INFO.JAVA"

package abstractTest1Pack;
public class XYZ extends ABC 
	{
    private String greeting;

    void setGreeting(String greeting) {
        this.greeting = greeting;
    }

    String DAY(String greeting) 
    {
        return greeting + " THURSDAY";
    }

    @Override
    String DAY() 
    {
        return greeting + " THURSDAY";
    }
}