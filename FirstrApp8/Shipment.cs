using System;
using System.Collections.Generic;
using System.Text;

namespace FirstrApp8
{
    internal class Shipment
    {
        // Private Fields
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;



        // TrackingCode (Read Only from outside)
        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    trackingCode = value;
            }
        }

        // Description
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    description = value;
            }
        }

        // Weight
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                    weight = value;
            }
        }

        // DeliveryFee
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                    deliveryFee = value;
            }
        }

        // Destination
        public DeliveryAddress Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        // Calculated Property
        public virtual decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (Weight * 5);
            }
        }

        // First Constructor
        public Shipment(string trackingCode)
        {
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        }

        // Second Constructor
        public Shipment(string trackingCode,
                        string description,
                        decimal weight,
                        decimal deliveryFee,
                        DeliveryAddress destination)
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        public void UpdateWeight(decimal weight)
        {
            Weight = weight;
        }

        public void UpdateWeight(decimal weight, decimal extraPackingWeight)
        {
            Weight = weight + extraPackingWeight;
        }



        // Add first Merhode
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }
        // Add two Methode

        public virtual void PrintShipment()
        {
            Console.WriteLine($"Tracking Code   : {TrackingCode}");
            Console.WriteLine($"Description     : {Description}");
            Console.WriteLine($"Weight          : {Weight} KG ");
            Console.WriteLine($"Delivery Fee    : {DeliveryFee} EGP");
            Console.WriteLine($"Destination     : {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost  : {EstimatedCost} EGP");
        }

















    }
}
