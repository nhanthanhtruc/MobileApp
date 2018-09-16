using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokeDexApp.Models
{
    public partial class Product
    {
        [JsonProperty("productId")]
        public long ProductId { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }

        [JsonProperty("supplierId")]
        public long SupplierId { get; set; }

        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("quantityPerUnit")]
        public string QuantityPerUnit { get; set; }

        [JsonProperty("unitPrice")]
        public long UnitPrice { get; set; }

        [JsonProperty("unitsInStock")]
        public long UnitsInStock { get; set; }

        [JsonProperty("unitsOnOrder")]
        public long UnitsOnOrder { get; set; }

        [JsonProperty("reorderLevel")]
        public long ReorderLevel { get; set; }

        [JsonProperty("discontinued")]
        public bool Discontinued { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("supplier")]
        public object Supplier { get; set; }

        [JsonProperty("orderDetails")]
        public object[] OrderDetails { get; set; }
    }
}
