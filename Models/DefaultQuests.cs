using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestConverter.Models
{
    class DefaultQuests
    {
        [JsonProperty("format:8")]
        public string format { get; set; }
        [JsonProperty("questDatabase:9")]
        public Dictionary<string, QuestItem> questDatabase { get; set; }
        [JsonProperty("questLines:9")]
        public Dictionary<string, PageItem> questLines { get; set; }
        [JsonProperty("questSettings:10")]
        public SettingsItem questSettings { get; set; }
    }
}
