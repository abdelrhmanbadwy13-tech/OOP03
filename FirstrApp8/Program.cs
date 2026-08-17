using System.Numerics;
using System.Xml.Linq;

namespace FirstrApp8
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            //  Q1
            // a) Method Overloading:
            // It is defining multiple methods with the same name but different parameters in the same class.

            //  Method Overriding:
            //It is redefining a method in a derived class that already exists in the base class using virtual and

            //b) Static Binding:
            //The method to be executed is determined at compile time.

            //Dynamic Binding:
            //The method to be executed is determined at runtime, depending on the actual object typ


            #endregion

            #region part01
            // Q2
            //a) 
            //The sealed keyword prevents a class from being inherited

            // b) 
            // A sealed class prevents the class from being inherited.
            // A sealed method prevents a method from being overridden in derived classes.

            //c)
            //No, a sealed method cannot be overridden because the sealed keyword prevents further overriding of the method in derived classes.


            #endregion

            #region part2


            // {
            //            Driver driver = new Driver(1, "Ahmed Mohamed", "01012345678");

            //            DeliveryCenter center = new DeliveryCenter("Delivery Center");
            //            center.Driver = driver;

            //            StandardShipment standard = new StandardShipment(
            //                "SH001",
            //                "Laptop",
            //                3,
            //                80,
            //                new DeliveryAddress("Cairo", "Nasr City", 10)
            //            );

            //            ExpressShipment express = new ExpressShipment(
            //                "SH002",
            //                "Mobile Phone",
            //                2,
            //                60,
            //                new DeliveryAddress("Cairo", "Maadi", 20),
            //                30
            //            );

            //            IntternationalShipment international = new IntternationalShipment(
            //                "SH003",
            //                "Television",
            //                8,
            //                120,
            //                new DeliveryAddress("Cairo", "Heliopolis", 30),
            //                "Germany",
            //                100
            //            );

            //            center.AddShipment(standard);
            //            center.AddShipment(express);
            //            center.AddShipment(international);

            //            Console.WriteLine("==========================================");
            //            Console.WriteLine("Delivery Center");
            //            Console.WriteLine("==========================================");
            //            Console.WriteLine($"Driver : {center.Driver.FullName}");
            //            Console.WriteLine("------------------------------------------");

            //            center.PrintAllShipments();

            //            Console.WriteLine("==========================================");
            //            Console.WriteLine("Printing Using DeliveryHelper...");

            //            Console.WriteLine("Standard Shipment Printed Successfully.");
            //            Console.WriteLine("Express Shipment Printed Successfully.");
            //            Console.WriteLine("International Shipment Printed Successfully.");

            //            Console.WriteLine("==========================================");
            //            Console.WriteLine("Updating Weight...");

            //            Console.WriteLine($"Original Weight : {standard.Weight} KG");

            //            standard.UpdateWeight(5);

            //            Console.WriteLine($"Updated Weight : {standard.Weight} KG");

            //            standard.UpdateWeight(5, 0.5m);

            //            Console.WriteLine($"Updated Weight After Packing : {standard.Weight} KG");

            //            Console.WriteLine("==========================================");
            //            Console.WriteLine("Printing Using Shipment[]...");

            //            Shipment[] shipments =
            //            {
            //    standard,
            //    express,
            //    international
            //};

            //            foreach (Shipment shipment in shipments)
            //            {
            //                if (shipment is StandardShipment)
            //                    Console.WriteLine("Standard Shipment...");

            //                else if (shipment is ExpressShipment)
            //                    Console.WriteLine("Express Shipment...");

            //                else if (shipment is IntternationalShipment)
            //                    Console.WriteLine("International Shipment...");
            //            }

            //            Console.WriteLine("==========================================");
            //        }


            #endregion

           
            #region OOP04 Part01
            //q1 
            // a- Abstraction is the process of hiding unnecessary implementation details
            // and showing only the essential features of an object to the user
            // b- Hide unnecessary implementation details.
            // Focus on the important features of an object.
            // 4 pillars
            // Encapsulation
            //Inheritance
            //Polymorphism
            //Abstraction

            // q2 
            // a- An abstract class can contain common data and behavior,
            // while an interface defines a contract that classes must implement
            //  b- We choose an interface when we want to define a common contract
            //  or behavior that different classes must implement.
            // c- A class cannot inherit from multiple classes, but it can implement multiple interfaces.
            #endregion




       


        }
    }
}
