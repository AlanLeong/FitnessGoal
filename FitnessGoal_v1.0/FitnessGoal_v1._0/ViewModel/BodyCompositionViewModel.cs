﻿using System;
//for azure mobile service
using Microsoft.WindowsAzure.MobileServices;
//for multithreading
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using FitnessGoal_v1._0;
using System.Linq;

namespace FitnessGoal_v1._0
{
    class BodyCompositionViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<BodyComposition> BodyCompositionTable;

        public List<BodyComposition> bodycompositionList { get; private set; }

        public BodyCompositionViewModel() 
        {
            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            BodyCompositionTable = client.GetTable<BodyComposition>();
        }

        async public Task<BodyComposition> GetMyCompositionList(string ID) 
        {
            try 
            {
                bodycompositionList = await BodyCompositionTable
                    .Where(a => a.RegistrationFK_ID == ID)
                    .ToListAsync();

                return bodycompositionList.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //Get Body Composition ID
        async public Task<string> GetBodyCompositionID(string r)
        {
            try
            {
                bodycompositionList = await BodyCompositionTable.ToListAsync();

                return bodycompositionList.Find(a => a.RegistrationFK_ID == r).BodyComposition_ID;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        async public void UpdateBodyComposition(BodyComposition item)
        {
            try
            {
                await BodyCompositionTable.UpdateAsync(item);

                // return personaldetailList.First();

            }
            catch (Exception e)
            {
                //return null;
            }
        }

        async public Task<int> ValidateButton(string b)
        {
            try
            {
                bodycompositionList = await BodyCompositionTable
                    .Where(a => a.RegistrationFK_ID == b).ToListAsync();

                if (bodycompositionList.Count > 0)
                {
                    return bodycompositionList.Count;
                }
                else 
                {
                    return bodycompositionList.Count;
                }
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
