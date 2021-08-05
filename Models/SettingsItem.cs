using Newtonsoft.Json;
using QuestConverter.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestConverter.Models
{
    public class SettingsItem
    {

        [JsonProperty("betterquesting:10")]
        public BetterQuestingGlobalProperty BetterQuesting { get; set; }


        public class BetterQuestingGlobalProperty
        {
            [JsonProperty("livesMax:3")]
            public int livesMax { get; set; }
            [JsonProperty("pack_name:8")]
            public string packName { get; set; }
            [JsonProperty("home_anchor_y:5")]
            public float homeAnchorY{ get; set; }
            [JsonProperty("livesDef:3")]
            public int livesDef { get; set; }
            [JsonProperty("home_anchor_x:5")]
            public float homeAnchorX { get; set; }
            [JsonProperty("hardcore:1")]
            [JsonConverter(typeof(BoolConverter))]
            public bool hardcore { get; set; }
            [JsonProperty("home_image:8")]
            public string homeImage { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("party_enable:1")]
            public bool partyEnable { get; set; }
            [JsonProperty("pack_version:3")]
            public int packVersion { get; set; }
            [JsonProperty("editMode:1")]
            [JsonConverter(typeof(BoolConverter))]
            public bool editMode { get; set; }
            [JsonProperty("home_offset_x:3")]
            public int homeOffsetX { get; set; }
            [JsonProperty("home_offset_y:3")]
            public int homeOffsetY { get; set; }

        }
    }
}
