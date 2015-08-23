using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;


namespace FitnessGoal_v1._0
{
    public class ProgressReport
    {
        public ProgressReport() { }

        [JsonProperty(PropertyName = "ID")]
        public string ProgressReport_ID { get; set; }

        [JsonProperty(PropertyName = "currentBMI")]
        public float currentBMI { get; set; }

        [JsonProperty(PropertyName = "currentBFP")]
        public float currentBFP { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "Registration_ID")]
        public string RegistrationFK_ID { get; set; }

        [JsonProperty(PropertyName = "__createdAt")]
        public string dateCreated { get; set; }
    }
}
