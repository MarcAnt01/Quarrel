using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quarrel.SharedModels;

namespace Quarrel.Gateway.DownstreamEvents
{
    public class GuildEmojiUpdate
    {
        [JsonProperty("guild_id")]
        public string GuildId { get; set; }
        [JsonProperty("emojis")]
        public IEnumerable<Emoji> Unavailable { get; set; }
    }
}
