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
    }
}
