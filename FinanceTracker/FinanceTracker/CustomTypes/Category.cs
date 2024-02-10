using MongoDB.Bson;
using Realms;

namespace FinanceTracker.CustomTypes
{
    public class Category : RealmObject
    {
        [PrimaryKey]
        [MapTo("_id")]
        public ObjectId Id { get; set; } = ObjectId.GenerateNewId();
        
        [MapTo("name")]
        public string Name { get; set; }

        [MapTo("description")]
        public string Description { get; set; }

        [MapTo("color")]
        public string Color { get; set; }

        public Category() { }

        public Category(string name, string description, string color)
        {
            Name = name;
            Description = description;
            Color = color;
        }
    }
}
