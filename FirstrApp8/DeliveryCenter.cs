using System;
using System.Collections.Generic;
using System.Text;

namespace FirstrApp8
{
    internal class DeliveryCenter
    {

        public Driver Driver { get; set; }
        private string centerName;
        public string CenterName
        {
            get { return centerName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    centerName = value;
            }
        }
        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
        }


        private Shipment[] shipments = new Shipment[20];


        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];
                return null;
            }

            set
            {

                if (index >= 0 && index < shipments.Length)

                    shipments[index] = value;
            }
        }

        // String Indexer .. 
        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (Shipment shipment in shipments)
                {
                    if (shipment != null &&
                        shipment.TrackingCode == trackingCode)
                    {
                        return shipment;
                    }
                }

                return null;

            }
        }


        // Add Shipment
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            return false;
        }
        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }
        public void PrintAllShipments()
        {
            foreach (Shipment shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine("----------------------");
                }
            }
        }








    }
}
