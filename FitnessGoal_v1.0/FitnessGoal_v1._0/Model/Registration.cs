using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.IO;
using System.Threading.Tasks;

namespace FitnessGoal_v1._0
{
    public class Registration
    {
        public Registration(string username, string password, string email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public Registration(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Registration()
        {
            // TODO: Complete member initialization
        }

        public static string Current { get; set; }

        public static bool IsUser { get; set; }

        [JsonProperty(PropertyName = "id")]
        public string Registration_ID { get; set; }

        [JsonProperty(PropertyName = "username")]
        public string username { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string password { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string email { get; set; }

        [JsonProperty(PropertyName = "ExerciseProgram_ID")]
        public string ExerciseProgram_ID { get; set; }

    }
}
