

using System.Collections.Generic;
using System.Linq;
using BaltaStore.Domain.StoreContext.ValueObjects;

namespace BaltaStore.Domain.StoreContext.Entities

{
    public class Customer
    {

        private readonly IList<Address> _address;
        public Customer(Name name, Document document, Email email, string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            _address = new List<Address>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> addresses => _address.ToArray();

        public override string ToString()
        {
            return Name.ToString();
        }

        public void AddAddress(Address address)
        {
            _address.Add(address);
        }
    }
}