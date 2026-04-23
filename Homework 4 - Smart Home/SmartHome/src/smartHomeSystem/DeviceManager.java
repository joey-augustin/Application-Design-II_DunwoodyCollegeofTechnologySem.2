package smartHomeSystem;

import java.util.ArrayList;

public class DeviceManager {
    private ArrayList<SmartDevice> devices;

    public DeviceManager() {
        devices = new ArrayList<>();
    }

    public void addDevice(SmartDevice device) {
        devices.add(device);
    }

    public void displayAllDevices() {
        System.out.println("\n===== DEVICE SUMMARY =====");

        if (devices.isEmpty()) {
            System.out.println("No devices to display.");
            return;
        }

        for (SmartDevice device : devices) {
            device.displayDeviceInfo();
        }
    }
}