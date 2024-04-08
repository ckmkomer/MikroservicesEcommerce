using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MikroservicesEcommerce.Catalog.Entities
{
    public class ProductDetail
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Description { get; set; }

        public string Info { get; set; }

        public string ProductId {  get; set; }
        [BsonIgnore]
         public Product Product { get; set; }
    }
}
