using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0.Model
{
    class BodyCompositionModel
    {
        public BodyCompositionModel()
        { }

        public BodyCompositionModel(double hip, double waist, double forearm, double height, double weight)
        {
            this.hip = hip;
            this.waist = waist;
            this.forearm = forearm;
            this.height = height;
            this.weight = weight;
        }

        public BodyCompositionModel(double bmi, double bfp)
        {
            this.bmi = bmi;
            this.bfp = bfp;
        }

        [JsonProperty(PropertyName = "id")]
        public double BodyComposition_ID { get; set; }

        [JsonProperty(PropertyName = "waist")]
        public double waist { get; set; }

        [JsonProperty(PropertyName = "hip")]
        public double hip { get; set; }

        [JsonProperty(PropertyName = "forearm")]
        public double forearm { get; set; }

        [JsonProperty(PropertyName = "height")]
        public double height { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public double weight { get; set; }

        [JsonProperty(PropertyName = "bmi")]
        public double bmi { get; set; }

        [JsonProperty(PropertyName = "bfp")]
        public double bfp { get; set; }

        [JsonProperty(PropertyName = "PersonalDetail_ID")]
        public string PersonalDetailFK_ID { get; set; }
    }
}
