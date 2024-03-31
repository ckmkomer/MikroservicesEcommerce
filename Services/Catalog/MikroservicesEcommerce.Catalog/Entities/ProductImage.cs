﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MikroservicesEcommerce.Catalog.Entities
{
    public class ProductImage
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }

        public string ProductId { get; set; }
        public Product Product { get; set; }


    }
}
