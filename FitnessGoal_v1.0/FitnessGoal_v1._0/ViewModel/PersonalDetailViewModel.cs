using System;
//for azure mobile service
using Microsoft.WindowsAzure.MobileServices;
//for multithreading
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using FitnessGoal_v1._0.Model;

namespace FitnessGoal_v1._0
{
    class PersonalDetailViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<PersonalDetailModel> PersonalDetailTable;
        private IMobileServiceTable<Registration> RegistrationTable;
        private IMobileServiceTable<BodyCompositionModel> BodyCompositionTable;

        public List<PersonalDetailModel> personaldetailList { get; private set; }

        public PersonalDetailViewModel() 
        {

            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            PersonalDetailTable = client.GetTable<PersonalDetailModel>();
            RegistrationTable = client.GetTable<Registration>();
            BodyCompositionTable = client.GetTable<BodyCompositionModel>();
        }

        //Add PersonalDetail function
        async public Task<bool> AddPersonalDetail(PersonalDetailModel p, BodyCompositionModel bc )
        {
            try 
            {
                PersonalDetailModel test = new PersonalDetailModel
                {
                    gender = "M",
                    age = 22,
                    status = "Active",
                    RegistrationFK_ID = "FDA107AE-C298-430D-9A13-34B503EB6E11"
                };
                Debug.WriteLine("42");
                await PersonalDetailTable.InsertAsync(test);
                //await BodyCompositionTable.InsertAsync(bc);
                Debug.WriteLine("45");
                return true;
       
            }
            catch (Exception e)
            {
                return false;
            }
        }

        async public Task<string> GetPersonalDetailID(PersonalDetailModel pdm)
        {
            try
            {

                personaldetailList = await PersonalDetailTable.ToListAsync();

                return personaldetailList.Find(a => a.RegistrationFK_ID == pdm.RegistrationFK_ID).PersonalDetail_ID;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
