package smartHomeSystem;

public class Light implements SmartDevice {
    private String name;
    private final String type = "Light";
    private int brightness;
    private boolean isOn;

    public Light(String name, int brightness, boolean isOn) {
        this.name = name;
        this.brightness = brightness;
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
        System.out.println("Brightness: " + brightness);
        System.out.println("Status: " + (isOn ? "ON" : "OFF"));
        System.out.println("----------------------");
    }
}