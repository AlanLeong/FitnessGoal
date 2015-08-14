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
        private IMobileServiceTable<Registration> RegistrationTable;
        private IMobileServiceTable<BodyComposition> BodyCompositionTable;

        private IMobileServiceTable<Bicep_Exe> BicepExeTable;
        private IMobileServiceTable<Bicep_SetRep> BicepSetRepTable;
        private IMobileServiceTable<BicepExe_BicepSetRep> BicepExeSetRepTable;

        private IMobileServiceTable<Chest_Exe> ChestExeTable;
        private IMobileServiceTable<Chest_SetRep> ChestSetRepTable;
        private IMobileServiceTable<ChestExe_ChestSetRep> ChestExeSetRepTable;

        private IMobileServiceTable<Shoulder_Exe> ShoulderExeTable;
        private IMobileServiceTable<Shoulder_SetRep> ShoulderSetRepTable;
        private IMobileServiceTable<ChestExe_ChestSetRep> ShoulderExeSetRepTable;

        public List<Bicep_Exe> bicep_exelist { get; private set; }
        public List<Bicep_SetRep> bicep_setreplist { get; private set; }
        public List<BicepExe_BicepSetRep> bicep_exesetreplist { get; private set; }

        public List<Chest_Exe> chest_exelist { get; private set; }
        public List<Chest_SetRep> chest_setreplist { get; private set; }
        public List<ChestExe_ChestSetRep> chest_exesetreplist { get; private set; }

        public List<Shoulder_Exe> shoulder_exelist { get; private set; }
        public List<Shoulder_SetRep> shoulder_setreplist { get; private set; }
        public List<ShoulderExe_ShoulderSetRep> shoulder_exesetreplist { get; private set; }

        public List<ExerciseProgramModel> ExerciseProgramList { get; private set; }
        public List<Registration> RegistrationList {get; private set;}
        public List<BodyComposition> bodycompositionList { get; private set; }

        public ExerciseProgramViewModel()
        {
            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            ExerciseProgramTable = client.GetTable<ExerciseProgramModel>();
            
        }


       //Get body composition list to see if the list exist
        async public Task<int> ValidateExerciseProgram(string ID)
        {
            try
            {
                bodycompositionList = await BodyCompositionTable
                    .Where(a => a.RegistrationFK_ID == ID)
                    .ToListAsync();

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
