using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;


namespace FitnessGoal_v1._0.Model
{
    class ProgressReportModel
    {
        [JsonProperty(PropertyName = "id")]
        public string ProgressReport_ID { get; set; }

        [JsonProperty(PropertyName = "currentBMI")]
        public string currentBMI { get; set; }

        [JsonProperty(PropertyName = "currentBFP")]
        public string currentBFP { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "PersonalDetail_ID")]
        public string PersonalDetailFK_ID { get; set; }

        [JsonProperty(PropertyName = "BodyComposition_ID")]
        public string BodyCompositionFK_ID { get; set; }
    }
}
