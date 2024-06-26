﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MikroservicesEcommerce.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public  string CaategoryId { get; set; }

        [BsonIgnore]
        public  Category Category { get; set; }


    }
}
