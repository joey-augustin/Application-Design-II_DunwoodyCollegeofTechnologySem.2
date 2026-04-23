package smartHomeSystem;

public class Thermostat implements SmartDevice {
    private String name;
    private final String type = "Thermostat";
    private double temperature;
    private boolean isOn;

    public Thermostat(String name, double temperature, boolean isOn) {
        this.name = name;
        this.temperature = temperature;
        this.isOn = isOn;
    }

    @Override
    public void turnOn() {
        isOn = true;
    }

    @Override
    public void turnOff() {
        isOn = false;
    }

    @Override
    public void displayDeviceInfo() {
        System.out.println("Device Name: " + name);
        System.out.println("Type: " + type);
        System.out.println("Temperature: " + temperature + "°F");
        System.out.println("Status: " + (isOn ? "ON" : "OFF"));
        System.out.println("----------------------");
    }
}