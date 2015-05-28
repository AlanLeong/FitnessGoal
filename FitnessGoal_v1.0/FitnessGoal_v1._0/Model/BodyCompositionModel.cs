using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0.Model
{
    class BodyCompositionModel
    {
        [JsonProperty(PropertyName = "id")]
        public string BodyComposition_ID { get; set; }

        [JsonProperty(PropertyName = "waist")]
        public string waist { get; set; }

        [JsonProperty(PropertyName = "hip")]
        public string hip { get; set; }

        [JsonProperty(PropertyName = "forearm")]
        public string forearm { get; set; }

        [JsonProperty(PropertyName = "height")]
        public string height { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public string weight { get; set; }

        [JsonProperty(PropertyName = "bmi")]
        public string bmi { get; set; }

        [JsonProperty(PropertyName = "bfp")]
        public string bfp { get; set; }

        [JsonProperty(PropertyName = "PersonalDetail_ID")]
        public string PersonalDetailFK_ID { get; set; }
    }
}
