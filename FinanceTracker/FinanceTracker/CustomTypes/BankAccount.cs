using MongoDB.Bson;
using Realms;

namespace FinanceTracker.CustomTypes
{
    public class BankAccount : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [MapTo("name")]
        public string Name { get; set; } = string.Empty;

        [MapTo("description")]
        public string Description { get; set; } = string.Empty;

        [MapTo("amount")]
        public double Amount { get; set; } = 0;

        public BankAccount() { }

        public BankAccount(string name, string description, double amount)
        {
            Name = name;
            Description = description;
            Amount = amount;
        }
    }
}
