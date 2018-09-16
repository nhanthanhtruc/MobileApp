using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MyShare
{
    public partial class Category
    {
        [JsonProperty("categoryId")]
        public long CategoryId { get; set; }

        [JsonProperty("categoryName")]
        public string CategoryName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }        
    }
}
