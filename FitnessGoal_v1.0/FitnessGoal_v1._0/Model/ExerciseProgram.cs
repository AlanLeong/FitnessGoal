using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class ExerciseProgram
    {

        public ExerciseProgram() { }

        [JsonProperty(PropertyName = "ID")]
        public string ExerciseProgram_ID { get; set; }

        [JsonProperty(PropertyName = "BicepExe_ID")]
        public string BicepExeSetRepFK_ID { get; set; }

        [JsonProperty(PropertyName = "ChestExe_ID")]
        public string ChestExeSetRepFK_ID { get; set; }

        [JsonProperty(PropertyName = "ShoulderExe_ID")]
        public string ShoulderExeSetRepFK_ID { get; set; }
    }
}
