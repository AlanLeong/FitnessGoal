using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0.Model
{
    public class BodyCompositionModel
    {
        public BodyCompositionModel()
        { }

        public BodyCompositionModel(float hip, float waist, float forearm, float height, float weight, float bmi, float bfp, string personaldetailFK)
        {
            this.hip = hip;
            this.waist = waist;
            this.forearm = forearm;
            this.height = height;
            this.weight = weight;
            this.bmi = bmi;
            this.bfp = bfp;
            this.PersonalDetailFK_ID = personaldetailFK;
        }

        //public BodyCompositionModel(float bmi, float bfp)
        //{
        //    this.bmi = bmi;
        //    this.bfp = bfp;
        //}

        [JsonProperty(PropertyName = "id")]
        public String BodyComposition_ID { get; set; }

        [JsonProperty(PropertyName = "waist")]
        public float waist { get; set; }

        [JsonProperty(PropertyName = "hip")]
        public float hip { get; set; }

        [JsonProperty(PropertyName = "forearm")]
        public float forearm { get; set; }

        [JsonProperty(PropertyName = "height")]
        public float height { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public float weight { get; set; }

        [JsonProperty(PropertyName = "bmi")]
        public float bmi { get; set; }

        [JsonProperty(PropertyName = "bfp")]
        public float bfp { get; set; }

        [JsonProperty(PropertyName = "PersonalDetail_ID")]
        public string PersonalDetailFK_ID { get; set; }
    }
}
