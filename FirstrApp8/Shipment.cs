using System;
using System.Collections.Generic;
using System.Text;

namespace FirstrApp8

{
    internal abstract partial class Shipment //oop4
    {
        // Private Fields
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        private DeliveryAddress destination;

        public static int TotalShipmentsCreated;

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
            set {
                if(value != null)
                
                destination = value; }
        }

        // Calculated Property
        public abstract decimal EstimatedCost
        {  get; }

        // First Constructor
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
            TotalShipmentsCreated++;
        }

        // Second Constructor
        public Shipment(string trackingCode)
                       
        {
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
            TotalShipmentsCreated++;
        }

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
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

        public abstract void PrintShipment();


        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        //internal static bool CalcualeInsurance()
        //{
        //    throw new NotImplementedException();
        //}

        public Shipment CopyShipment()
        {
            return (Shipment)MemberwiseClone();
        }
        public Shipment ShallowCopy()
        {
            return (Shipment)MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)MemberwiseClone();

            copy.Destination = new DeliveryAddress(
                Destination.City,
                Destination.Street,
                Destination.BuildingNumber
            );

            return copy;
        }

    }
}
