using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class Chest_Exe
    {
        public Chest_Exe() { }

        [JsonProperty(PropertyName = "ID")]
        public string ChestExe_ID { get; set; }

        [JsonProperty(PropertyName = "Typeof_Exercise")]
        public string TypeofExercise { get; set; }
    }
}
