using Newtonsoft.Json;

namespace QuestConverter.Models
{
    public class MinecraftFluid
    {
        [JsonProperty("FluidName:8")]
        public string FluidName { get; set; }
        [JsonProperty("Amount:3")]
        public int Amount { get; set; }
    }
}