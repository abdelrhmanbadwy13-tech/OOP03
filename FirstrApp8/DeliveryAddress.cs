using System;
using System.Collections.Generic;
using System.Text;

namespace FirstrApp8
{
    internal class DeliveryAddress
    {

        public string City;
        public string Street;
        public int BuildingNumber;

        public DeliveryAddress(string city, string street, int buildingNumber) //con
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;

        }
        public string GetFullAddress() // methode
        {
            return $"{BuildingNumber} , {Street}, {City}";
        }




    }
}
