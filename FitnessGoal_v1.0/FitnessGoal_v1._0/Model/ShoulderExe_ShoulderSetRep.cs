using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    class ShoulderExe_ShoulderSetRep
    {
        public ShoulderExe_ShoulderSetRep() { }

        [JsonProperty(PropertyName = "ID")]
        public string ShoulderExeSetRepID { get; set; }

        [JsonProperty(PropertyName = "ShoulderExe_ID")]
        public string ShoulderExeFK_ID { get; set; }

        [JsonProperty(PropertyName = "Shoulder_SetRepID")]
        public string ShoulderSetRepFK_ID { get; set; }
    }
}
