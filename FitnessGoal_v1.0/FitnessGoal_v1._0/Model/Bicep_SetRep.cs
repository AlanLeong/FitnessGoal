using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    class Bicep_SetRep
    {
        public Bicep_SetRep() { }

        [JsonProperty(PropertyName = "ID")]
        public string BicepSetRep_ID { get; set; }

        [JsonProperty(PropertyName = "Bicep_ID")]
        public string BicepFK_ID { get; set; }

        [JsonProperty(PropertyName = "Set")]
        public string Set { get; set; }

        [JsonProperty(PropertyName = "Rep")]
        public string Rep { get; set; }

        [JsonProperty(PropertyName = "Weight")]
        public string Weight { get; set; }

    }
}
