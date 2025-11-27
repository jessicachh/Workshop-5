using System;
using System.Collections.Generic;

namespace ElectronicsDemo
{
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to store.");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            devices.Remove(device);
            Console.WriteLine($"{device.Brand} removed from store.");
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n=== Store Device Details ===");

            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcasting to call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone phone)
                {
                    phone.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}
