using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    class ChestExe_ChestSetRep
    {
        public ChestExe_ChestSetRep() { }

        [JsonProperty(PropertyName = "ID")]
        public string ChestExeSetRepID { get; set; }

        [JsonProperty(PropertyName = "ChestExe_ID")]
        public string ChestExeFK_ID { get; set; }

        [JsonProperty(PropertyName = "Chest_SetRepID")]
        public string ChestSetRepFK_ID { get; set; }
    }
}
