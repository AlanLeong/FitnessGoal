using System;
//for azure mobile service
using Microsoft.WindowsAzure.MobileServices;
//for multithreading
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace FitnessGoal_v1._0
{
    class PersonalDetailViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<PersonalDetailModel> PersonalDetailTable;

        public List<PersonalDetailModel> PersonalDetailList { get; private set; }

        public PersonalDetailViewModel() 
        {
            PersonalDetailList = new List<PersonalDetailModel>();

            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            PersonalDetailTable = client.GetTable<PersonalDetailModel>();
        }

        //Add Detail function
    }
}
