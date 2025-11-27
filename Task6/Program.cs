using System;
using ElectronicsDemo;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        // Creating devices
        Laptop laptop = new Laptop("Dell", 85000);
        Smartphone phone = new Smartphone("Samsung", 45000);

        // Add to store
        store.AddDevice(laptop);
        store.AddDevice(phone);

        // Show details
        store.ShowAllDeviceDetails();
    }
}
