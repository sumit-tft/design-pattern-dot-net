using System;

// Abstract Product
public abstract class Vehicle
{
    public abstract void Manufacture();
}

// Concrete Products
public class Car : Vehicle
{
    public override void Manufacture()
    {
        Console.WriteLine("Manufacturing a car.");
    }
}

public class Truck : Vehicle
{
    public override void Manufacture()
    {
        Console.WriteLine("Manufacturing a truck.");
    }
}

public class Motorcycle : Vehicle
{
    public override void Manufacture()
    {
        Console.WriteLine("Manufacturing a motorcycle.");
    }
}

// Abstract Creator
public abstract class VehicleFactory
{
    public abstract Vehicle CreateVehicle();
}

// Concrete Creators
public class CarFactory : VehicleFactory
{
    public override Vehicle CreateVehicle()
    {
        return new Car();
    }
}

public class TruckFactory : VehicleFactory
{
    public override Vehicle CreateVehicle()
    {
        return new Truck();
    }
}

public class MotorcycleFactory : VehicleFactory
{
    public override Vehicle CreateVehicle()
    {
        return new Motorcycle();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a car using the CarFactory
        VehicleFactory carFactory = new CarFactory();
        Vehicle car = carFactory.CreateVehicle();
        car.Manufacture();

        // Create a truck using the TruckFactory
        VehicleFactory truckFactory = new TruckFactory();
        Vehicle truck = truckFactory.CreateVehicle();
        truck.Manufacture();

        // Create a motorcycle using the MotorcycleFactory
        VehicleFactory motorcycleFactory = new MotorcycleFactory();
        Vehicle motorcycle = motorcycleFactory.CreateVehicle();
        motorcycle.Manufacture();
    }
}
