

using BaltaStore.Domain.StoreContext.Emuns;
using BaltaStore.Domain.StoreContext.ValueObjects;

namespace BaltaStore.Domain.StoreContext.Entities

{
    public class Address
    {
        public Address(string street, string number, string complement, string district, string city, string state, string zipCode, string country, EAddressType type)
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            Type = type;
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public EAddressType Type { get; private set; }

        public override string ToString()
        {
            return $"{Street}, {Number} - {City}/{State}";
        }


    }
}