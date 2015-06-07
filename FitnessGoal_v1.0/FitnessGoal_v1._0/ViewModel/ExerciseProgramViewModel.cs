using System;
//for azure mobile service
using Microsoft.WindowsAzure.MobileServices;
//for multithreading
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;
using FitnessGoal_v1._0.Model;

namespace FitnessGoal_v1._0.ViewModel
{
    class ExerciseProgramViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<ExerciseProgramModel> ExerciseProgramTable;
        private IMobileServiceTable<Bicep_Exe> BicepExeTable;
        private IMobileServiceTable<Bicep_SetRep> BicepsetRepTable;
        private IMobileServiceTable<BicepExe_BicepSetRep> BicepExeSetRepTable;

        public List<ExerciseProgramModel> ExerciseProgramList { get; private set; }

        public ExerciseProgramViewModel()
        {
            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            ExerciseProgramTable = client.GetTable<ExerciseProgramModel>();
            
        }

        //Retrieve data function


    }
}
