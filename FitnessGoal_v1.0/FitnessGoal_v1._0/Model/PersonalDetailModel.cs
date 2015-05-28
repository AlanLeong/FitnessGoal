using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class PersonalDetailModel
    {
        [JsonProperty(PropertyName = "id")]
        public string PersonalDetail_ID { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string gender { get; set; }

        [JsonProperty(PropertyName = "age")]
        public string age { get; set; }

        [JsonProperty(PropertyName = "Registration_ID")]
        public string RegistrationFK_ID { get; set; }

    }
}
