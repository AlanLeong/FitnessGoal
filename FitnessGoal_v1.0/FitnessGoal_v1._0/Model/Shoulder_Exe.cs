using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class Shoulder_Exe
    {
        public Shoulder_Exe() { }

        [JsonProperty(PropertyName = "ID")]
        public string ShoulderExe_ID { get; set; }

        [JsonProperty(PropertyName = "Typeof_Exercise")]
        public string TypeofExercise { get; set; }
    }
}
