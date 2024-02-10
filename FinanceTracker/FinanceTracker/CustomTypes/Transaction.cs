using MongoDB.Bson;
using Realms;

namespace FinanceTracker.CustomTypes
{
    public class Transaction : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();

        [MapTo("date")]
        public string Date { get; set; } = DateTime.MinValue.ToString("dd.MM.yyyy");

        [MapTo("description")]
        public string Description { get; set; } = string.Empty;

        [MapTo("value")]
        public double Value { get; set; } = 0;

        [MapTo("account")]
        public BankAccount Account { get; set; }

        public Transaction() { }

        public Transaction(string date, string description, double value, BankAccount account)
        {
            Date = date;
            Description = description;
            Value = value;
            Account = account;
        }
    }
}
