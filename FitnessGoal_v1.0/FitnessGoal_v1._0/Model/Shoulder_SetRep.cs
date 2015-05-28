using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0.Model
{
    class Shoulder_SetRep
    {
        [JsonProperty(PropertyName = "id")]
        public string Shoulder_SetRepID { get; set; }

        [JsonProperty(PropertyName = "Shoulder_ID")]
        public string Shoulder_ID { get; set; }

        [JsonProperty(PropertyName = "PersonalDetail_ID")]
        public string PersonalDetailFK_ID { get; set; }

        [JsonProperty(PropertyName = "Set")]
        public string Set { get; set; }

        [JsonProperty(PropertyName = "Rep")]
        public string Rep { get; set; }

        [JsonProperty(PropertyName = "Weight")]
        public string Weight { get; set; }
    }
}
