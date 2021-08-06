using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public string NameKeyIdBased { get
            {
                return "bq.questline" + lineID + ".name";
            } 
        }
        [JsonIgnore]
        public string DescKeyIdBased
        {
            get
            {
                return "bq.questline" + lineID + ".desc";
            }
        }

        [JsonIgnore]
        public string NameKeyNameBased
        {
            get
            {
                return "bq.questline." + keyFromName + ".name";
            }
        }
        [JsonIgnore]
        public string DescKeyNameBased
        {
            get
            {
                return "bq.questline." + keyFromName + ".desc";
            }
        }

        [JsonIgnore]
        public string keyFromName
        {
            get
            {
                return Regex.Replace(Regex.Replace(properties.betterQuesting.name, "[^a-zA-Z0-9 ]", String.Empty), " ", "_").ToLowerInvariant();
            }
        }
    }
}
