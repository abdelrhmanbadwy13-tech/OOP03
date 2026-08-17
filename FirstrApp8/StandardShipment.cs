using System;
using System.Collections.Generic;
using System.Text;

namespace FirstrApp8
{
    internal class StandardShipment : Shipment , ITrackable , IInsurable
    {

        public StandardShipment(string trackingCode,
                     string description,
                        decimal weight,
                         decimal deliveryFee,
    DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost
            => DeliveryFee + (Weight * 5);

        public decimal CalculateInsurance()
        {

            return EstimatedCost * 5 / 100;
            
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready.";
        }

        public override void PrintShipment()
       
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description : {Description}");
           // Console.WriteLine($"Weight : {Weight} KG");
           // Console.WriteLine($"Delivery Fee : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }


    }
}
