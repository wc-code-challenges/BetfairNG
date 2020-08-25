using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BetfairNG.Data
{
    public class CancelInstruction
    {
        [JsonProperty(PropertyName = "betId")]
        public string BetId { get; set; }

        /// <summary>
        /// https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Enums#BettingEnums-InstructionReportStatus
        /// https://docs.developer.betfair.com/display/1smk3cen4v3lu3yomq5qye0ni/Betting+Type+Definitions#BettingTypeDefinitions-CancelInstruction see size reduction field
        /// </summary>
        [JsonProperty(PropertyName = "sizeReduction")]
        public double? SizeReduction { get; set; } 
    }
}
