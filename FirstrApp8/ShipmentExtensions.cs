using System;
using System.Collections.Generic;
using System.Text;

namespace FirstrApp8
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | " +
                   $"{shipment.Description} | " +
                   $"{shipment.Weight} KG | " +
                   $"{shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus == "Delivered";
        }
    }
}
