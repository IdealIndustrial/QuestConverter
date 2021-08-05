using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestConverter.Models
{
    public class PageItem
    {
        [JsonProperty("quests:9")] 
        public Dictionary<string, QuestLink> quests { get; set; }
        [JsonProperty("lineID:3")]
        public int lineID { get; set; }
        [JsonProperty("properties:10")]
        public PageProperty properties { get; set; }
        [JsonProperty("order:3")]
        public int order { get; set; }

        public class PageProperty
        {
            [JsonProperty("betterquesting:10")]
            public BetterQuestingPageProperty betterQuesting { get; set; }
        }

        public class BetterQuestingPageProperty
        {
            [JsonProperty("visibility:8")]
            public string visibility { get; set; }
            [JsonProperty("name:8")]
            public string name { get; set; }
            [JsonProperty("icon:10")]
            public MinecraftItem icon { get; set; }
            [JsonProperty("bg_image:8")]
            public string bgImage { get; set; }
            [JsonProperty("bg_size:3")]
            public int bgSize { get; set; }
            [JsonProperty("desc:8")]
            public string desc { get; set; }

        }

        [JsonIgnore]
        public string NameKey { get
            {
                return "questLine" + lineID + ".name";
            } 
        }
        [JsonIgnore]
        public string DescKey
        {
            get
            {
                return "questLine" + lineID + ".desc";
            }
        }
    }
}
