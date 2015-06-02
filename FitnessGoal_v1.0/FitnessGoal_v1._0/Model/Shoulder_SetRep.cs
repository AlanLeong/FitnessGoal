﻿using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    class Shoulder_SetRep
    {
        public Shoulder_SetRep() { }

        [JsonProperty(PropertyName = "ID")]
        public string ShoulderSetRep_ID { get; set; }

        [JsonProperty(PropertyName = "Shoulder_ID")]
        public string ShoulderFK_ID { get; set; }

        [JsonProperty(PropertyName = "Set")]
        public string Set { get; set; }

        [JsonProperty(PropertyName = "Rep")]
        public string Rep { get; set; }

        [JsonProperty(PropertyName = "Weight")]
        public string Weight { get; set; }
    }
}
