using Newtonsoft.Json;
using QuestConverter.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestConverter.Models
{
    partial class QuestItem
    {
        [JsonProperty("questID:3")]
        public int questID { get; set; }
        [JsonProperty("preRequisites:11")]
        public int[] preRequisites { get; set; }
        [JsonProperty("properties:10")]
        public QuestProperty properties { get; set; }
        [JsonProperty("tasks:9")]
        public Dictionary<string, QuestTask> tasks
        {
            get; set;
        }
        [JsonProperty("rewards:9")]
        public Dictionary<string, QuestReward> rewards
        {
            get; set;
        }


        [JsonIgnore]
        public string NameKey
        {
            get
            {
                return "quest" + questID + ".name";
            }
        }
        [JsonIgnore]
        public string DescKey
        {
            get
            {
                return "quest" + questID + ".desc";
            }
        }

        public class QuestProperty
        {
            [JsonProperty("betterquesting:10")]
            public BetterQuestingQuestProperty betterQuesting { get; set; }
        }

        public class BetterQuestingQuestProperty
        {
            [JsonProperty("snd_complete:8")]
            public string sndComplete { get; set; }
            [JsonProperty("taskLogic:8")]
            public string taskLogic { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("partySingleReward:1")]
            public bool partySingleReward { get; set; }
            [JsonProperty("visibility:8")]
            public string visibility { get; set; }
            [JsonProperty("isMain:1")]
            [JsonConverter(typeof(BoolConverter))]
            public bool isMain { get; set; }
            [JsonProperty("simultaneous:1")]
            [JsonConverter(typeof(BoolConverter))]
            public bool simultaneous { get; set; }
            [JsonProperty("icon:10")]
            public MinecraftItem Icon { get; set; }
            [JsonProperty("snd_update:8")]
            public string sndUpdate { get; set; }
            [JsonProperty("repeatTime:3")]
            public int repeatTime { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("globalShare:1")]
            public bool globalShare { get; set; }
            [JsonProperty("questLogic:8")]
            public string questLogic { get; set; }
            [JsonProperty("name:8")]
            public string name { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("lockedProgress:1")]
            public bool lockedProgress { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("autoClaim:1")]
            public bool autoClaim { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("isSilent:1")]
            public bool isSilent { get; set; }
            [JsonProperty("desc:8")]
            public string desc { get; set; }
        }

        public class QuestTask
        {
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("partialMatch:1")]
            public bool? partialMatch { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("autoConsume:1")]
            public bool autoConsume { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("groupDetect:1")]
            public bool groupDetect { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("ignoreNBT:1")]
            public bool ignoreNBT { get; set; }
            [JsonProperty("index:3")]
            public int index { get; set; }
            [JsonConverter(typeof(BoolConverter))]
            [JsonProperty("consume:1")]
            public bool consume { get; set; }
            [JsonProperty("requiredItems:9")]
            public Dictionary<string, MinecraftItem> requiredItems { get; set; }
            [JsonProperty("requiredFluids:9")]
            public Dictionary<string, MinecraftFluid> requiredFluids { get; set; }
            [JsonProperty("taskID:8")]
            public string taskID { get; set; }
        }

        public class QuestReward
        {
            [JsonProperty("rewardID:8")]
            public string rewardID { get; set; }
            [JsonProperty("index:3")]
            public int index { get; set; }
            [JsonProperty("choices:9")]
            public Dictionary<string, MinecraftItem> choices { get; set; }
            [JsonProperty("rewards:9")]
            public Dictionary<string, MinecraftItem> rewards { get; set; }
        }
    }
}
