using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class ExerciseProgramModel
    {

        public ExerciseProgramModel() { }

        public ExerciseProgramModel(string BicepExe_ID, string ChestExe_ID, string ShoulderExe_ID)
        {
            this.BicepExe_ID = BicepExe_ID;
            this.ChestExe_ID = ChestExe_ID;
            this.ShoulderExe_ID = ShoulderExe_ID;
        }

        [JsonProperty(PropertyName = "ID")]
        public string ExerciseProgram_ID { get; set; }

        [JsonProperty(PropertyName = "BicepExe_ID")]
        public string BicepExe_ID { get; set; }

        [JsonProperty(PropertyName = "ChestExe_ID")]
        public string ChestExe_ID { get; set; }

        [JsonProperty(PropertyName = "ShoulderExe_ID")]
        public string ShoulderExe_ID { get; set; }
    }
}
