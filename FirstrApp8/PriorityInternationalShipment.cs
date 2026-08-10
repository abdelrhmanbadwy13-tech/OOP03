using System;
using System.Collections.Generic;
using System.Text;

namespace FirstrApp8
{
    internal class PriorityInternationalShipment : IntternationalShipment
    {
        public PriorityInternationalShipment(
        string trackingCode,
        string description,
        decimal weight,
        decimal deliveryFee,
        DeliveryAddress destination,
        string destinationCountry,
        decimal customsFee)
        : base(
            trackingCode,
            description,
            weight,
            deliveryFee,
            destination,
            destinationCountry,
            customsFee)
        {
        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Priority Customs Report");
        }


    }
}
