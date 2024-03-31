﻿namespace MikroservicesEcommerce.Catalog.Settings
{
    public interface IDatabaseSettings
    {
     
     public string  CategoryCollectionMane { get; set; }
     public string ProductCollectionName { get; set; }

     public string ProductDetailCollectionName { get; set; }

     public string ProductImageCollectionName {  get; set; }
     public string ConnectionString { get; set; }
     public string DatabaseName { get; set; }
    }
}
