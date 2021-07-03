using System;
using Newtonsoft.Json;


    public class StoreApp
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        [JsonProperty("people")]
        public string People { get; set; }

        [JsonProperty("category")]
        public String Category { get; set; }

        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }
    
}