using Newtonsoft.Json;
using System.Collections.Generic;

namespace QuestConverter.Models
{

    public class MinecraftItem
    {
        [JsonProperty("id:8")]
        public string id { get; set; }
        [JsonProperty("Count:3")]
        public int count { get; set; }
        [JsonProperty("tag:10")]
        public Dictionary<string, dynamic> tag { get; set; }
        [JsonProperty("Damage:2")]
        public int damage { get; set; }
        [JsonProperty("OreDict:8")]
        public string oreDict { get; set; }
    }

    //public class ItemTag
    //{
    //    [JsonProperty("tileEntity:10")]
    //    public TileEntityTag tileEntity { get; set; }
    //    [JsonProperty("freq:4")]
    //    public long? freq { get; set; }

    //    public class TileEntityTag
    //    {
    //        [JsonProperty("FluidName:8")]
    //        public string FluidName { get; set; }
    //        [JsonProperty("Amount:3")]
    //        public int Amount { get; set; }
    //    }
    //}
}
