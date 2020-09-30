using System;
using NSE.Core.DomainObjects;

namespace NSE.Clients.API.Models
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Guid ClientId { get; set; }
        
        public Client Client { get; set; }
        public Address(string street, string street2, string number, string zipCode, string city, string state)
        {
            Street = street;
            Street2 = street2;
            Number = number;
            ZipCode = zipCode;
            City = city;
            State = state;
        }
    }
}