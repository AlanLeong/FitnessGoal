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
        private IMobileServiceTable<Bicep_SetRep> BicepSetRepTable;
        private IMobileServiceTable<BicepExe_BicepSetRep> BicepExeSetRepTable;

        private IMobileServiceTable<Chest_Exe> ChestExeTable;
        private IMobileServiceTable<Chest_SetRep> ChestSetRepTable;
        private IMobileServiceTable<ChestExe_ChestSetRep> ChestExeSetRepTable;

        private IMobileServiceTable<Shoulder_Exe> ShoulderExeTable;
        private IMobileServiceTable<Shoulder_SetRep> ShoulderSetRepTable;
        private IMobileServiceTable<ChestExe_ChestSetRep> ShoulderExeSetRepTable;



        public List<ExerciseProgramModel> ExerciseProgramList { get; private set; }

        public ExerciseProgramViewModel()
        {
            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            ExerciseProgramTable = client.GetTable<ExerciseProgramModel>();
            
        }

        //Retrieve data function


    }
}
