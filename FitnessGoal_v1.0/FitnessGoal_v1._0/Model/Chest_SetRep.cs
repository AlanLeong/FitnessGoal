using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class Chest_SetRep
    {
        public Chest_SetRep() { }

        [JsonProperty(PropertyName = "ID")]
        public string ChestSetRep_ID { get; set; }

        [JsonProperty(PropertyName = "Chest_ID")]
        public string ChestFK_ID { get; set; }

        [JsonProperty(PropertyName = "Set")]
        public int Set { get; set; }

        [JsonProperty(PropertyName = "Rep")]
        public int Rep { get; set; }

        [JsonProperty(PropertyName = "Weight")]
        public float Weight { get; set; }
    }
}
