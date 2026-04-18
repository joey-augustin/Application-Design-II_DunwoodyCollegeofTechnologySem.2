package operationsUnitTesting;

import static org.junit.jupiter.api.Assertions.assertEquals;
import org.junit.jupiter.api.Test;
import operationsLibrary.TemperatureConverter;

public class TemperatureUnitTesting {

	@Test
    public void testCelsiusToFahrenheit() {
        //ARRANGE
        double input = 0.0;
        double expected = 32.0;

        //ACT
        double result = TemperatureConverter.celsiusToFahrenheit(input);

        //ASSERT
        assertEquals(expected, result);
    }

    @Test
    public void testFahrenheitToCelsius() {
        //ARRANGE
        double input = 32.0;
        double expected = 0.0;

        //ACT
        double result = TemperatureConverter.fahrenheitToCelsius(input);

        //ASSERT
        assertEquals(expected, result);
    }
}
