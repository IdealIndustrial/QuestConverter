using Newtonsoft.Json;

namespace QuestConverter.Models
{
    public class QuestLink
    {
        [JsonProperty("sizeX:3")]
        public int sizeX { get; set; }
        [JsonProperty("x:3")]
        public int x { get; set; }
        [JsonProperty("y:3")]
        public int y { get; set; }
        [JsonProperty("id:3")]
        public int id { get; set; }
        [JsonProperty("sizeY:3")]
        public int sizeY { get; set; }
    }
}
