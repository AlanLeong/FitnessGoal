using System;
//for azure mobile service
using Microsoft.WindowsAzure.MobileServices;
//for multithreading
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using FitnessGoal_v1._0.Model;
using System.Linq;

namespace FitnessGoal_v1._0
{
    class PersonalDetailViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<PersonalDetail> PersonalDetailTable;
        private IMobileServiceTable<Registration> RegistrationTable;
        private IMobileServiceTable<BodyComposition> BodyCompositionTable;
        //private IMobileServiceTable<ExerciseProgramModel> ExerciseProgramTable;

        public List<PersonalDetail> personaldetailList { get; private set; }
        //public List<ExerciseProgramModel> ExerciseProgramList { get; private set; }

        public PersonalDetailViewModel() 
        {

            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            PersonalDetailTable = client.GetTable<PersonalDetail>();
            RegistrationTable = client.GetTable<Registration>();
            BodyCompositionTable = client.GetTable<BodyComposition>();
            
        }

        //Add PersonalDetail function
        async public Task<bool> AddPersonalDetail(PersonalDetail p, BodyComposition bc )
        {
            try 
            {
                await PersonalDetailTable.InsertAsync(p);
                await BodyCompositionTable.InsertAsync(bc);
                //Debug.WriteLine("45");
                return true;
       
            }
            catch (Exception e)
            {
                return false;
            }
        }

        async public Task<string> GetPersonalDetailID(string item)
        {
            try
            {

                personaldetailList = await PersonalDetailTable.ToListAsync();

                return personaldetailList.Find(a => a.RegistrationFK_ID == item).PersonalDetail_ID;
                    //pdm.RegistrationFK_ID).PersonalDetail_ID;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        async public void UpdateProfileList(PersonalDetail item)
        {
            try 
            {
                await PersonalDetailTable.UpdateAsync(item);

               // return personaldetailList.First();

            }
            catch (Exception e) 
            {
                //return null;
            }
        }

        async public Task<PersonalDetail> GetMyProfileList(string ID) 
        {
            try 
            {         
                personaldetailList = await PersonalDetailTable
                    .Where(a => a.RegistrationFK_ID == ID)
                    .ToListAsync();

                //.first = to get first row data from db
                return personaldetailList.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }


    }

}
