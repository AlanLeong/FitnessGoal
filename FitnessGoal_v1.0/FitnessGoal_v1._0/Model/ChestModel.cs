using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;
namespace FitnessGoal_v1._0.Model
{
    class ChestModel
    {
        [JsonProperty(PropertyName = "id")]
        public string Chest_ID { get; set; }

        [JsonProperty(PropertyName = "Typeof_Exercise")]
        public string username { get; set; }

        [JsonProperty(PropertyName = "PersonalDetail_ID")]
        public string PersonalDetailFK_ID { get; set; }
    }
}
