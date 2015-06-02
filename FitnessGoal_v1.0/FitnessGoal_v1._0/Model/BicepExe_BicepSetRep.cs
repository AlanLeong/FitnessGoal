using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    class BicepExe_BicepSetRep
    {
        public BicepExe_BicepSetRep() { }

        [JsonProperty(PropertyName = "ID")]
        public string BicepExeSetRepID { get; set; }

        [JsonProperty(PropertyName = "BicepExe_ID")]
        public string BicepExeFK_ID { get; set; }

        [JsonProperty(PropertyName = "Bicep_SetRepID")]
        public string BicepSetRepFK_ID { get; set; }
    }
}
