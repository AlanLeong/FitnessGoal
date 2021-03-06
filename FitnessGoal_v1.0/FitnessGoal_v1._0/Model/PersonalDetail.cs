﻿using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class PersonalDetail
    {
        public PersonalDetail()
        { }

        //public PersonalDetailModel(string gender, int age, string RegistrationID)
        //{
        //    this.gender = gender;
        //    this.age = age;
        //    this.RegistrationFK_ID = RegistrationID;
        //}

        [JsonProperty(PropertyName = "ID")]
        public string PersonalDetail_ID { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public string gender { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int age { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "Registration_ID")]
        public string RegistrationFK_ID { get; set; }

    }
}
