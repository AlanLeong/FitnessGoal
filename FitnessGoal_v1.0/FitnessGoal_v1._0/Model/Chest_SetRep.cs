using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0.Model
{
    class Chest_SetRep
    {
        [JsonProperty(PropertyName = "id")]
        public string Chest_SetRepID { get; set; }

        [JsonProperty(PropertyName = "Chest_ID")]
        public string Chest_ID { get; set; }

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
