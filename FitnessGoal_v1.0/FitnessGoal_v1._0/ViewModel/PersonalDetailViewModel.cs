﻿using System;
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
                await PersonalDetailTable.InsertAsync(p);
                //await RegistrationTable.InsertAsync(r);
                await BodyCompositionTable.InsertAsync(bc);

                return true;
       
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
