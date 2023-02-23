using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Stone.App.Purchase.Domain.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string BirthDate { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IEnumerable<int> PurchasedApps { get; set; }
    }
}
