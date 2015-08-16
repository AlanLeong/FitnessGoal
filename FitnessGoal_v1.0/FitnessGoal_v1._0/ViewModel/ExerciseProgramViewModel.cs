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
    class ExerciseProgramViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<ExerciseProgram> ExerciseProgramTable;
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
        private IMobileServiceTable<ShoulderExe_ShoulderSetRep> ShoulderExeSetRepTable;

        public List<Bicep_Exe> bicep_exelist { get; private set; }
        public List<Bicep_SetRep> bicep_setreplist { get; private set; }
        public List<BicepExe_BicepSetRep> bicep_exesetreplist { get; private set; }

        public List<Chest_Exe> chest_exelist { get; private set; }
        public List<Chest_SetRep> chest_setreplist { get; private set; }
        public List<ChestExe_ChestSetRep> chest_exesetreplist { get; private set; }

        public List<Shoulder_Exe> shoulder_exelist { get; private set; }
        public List<Shoulder_SetRep> shoulder_setreplist { get; private set; }
        public List<ShoulderExe_ShoulderSetRep> shoulder_exesetreplist { get; private set; }

        public List<ExerciseProgram> ExerciseProgramList { get; private set; }
        public List<Registration> RegistrationList {get; private set;}
        public List<BodyComposition> bodycompositionList { get; private set; }

        public ExerciseProgramViewModel()
        {
            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            ExerciseProgramTable = client.GetTable<ExerciseProgram>();
            BodyCompositionTable = client.GetTable<BodyComposition>();
            RegistrationTable = client.GetTable<Registration>();

            BicepExeTable = client.GetTable<Bicep_Exe>();
            BicepSetRepTable = client.GetTable<Bicep_SetRep>();
            BicepExeSetRepTable = client.GetTable<BicepExe_BicepSetRep>();

            ChestExeTable = client.GetTable<Chest_Exe>();
            ChestSetRepTable = client.GetTable<Chest_SetRep>();
            ChestExeSetRepTable = client.GetTable<ChestExe_ChestSetRep>();

            ShoulderExeTable = client.GetTable<Shoulder_Exe>();
            ShoulderSetRepTable = client.GetTable<Shoulder_SetRep>();
            ShoulderExeSetRepTable = client.GetTable<ShoulderExe_ShoulderSetRep>();         
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

        //get bicep_exe list
        async public Task<Bicep_Exe> GetBicep_ExeList(string ID)
        {
            try
            {
                bicep_exelist = await BicepExeTable
                    .Where(a => a.BicepExe_ID == ID)
                    .ToListAsync();

                return bicep_exelist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get bicep_setrep list
        async public Task<Bicep_SetRep> GetBicep_setrepList(string ID)
        {
            try
            {
                bicep_setreplist = await BicepSetRepTable
                    .Where(a => a.BicepSetRep_ID == ID)
                    .ToListAsync();

                return bicep_setreplist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get bicep_exesetrep list
        async public Task<BicepExe_BicepSetRep> GetBicep_ExeSetRepList(string ID)
        {
            try
            {
                bicep_exesetreplist = await BicepExeSetRepTable
                    .Where(a => a.BicepExeSetRepID == ID)
                    .ToListAsync();

                return bicep_exesetreplist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get chest_exe list
        async public Task<Chest_Exe> GetChest_ExeList(string ID)
        {
            try
            {
                chest_exelist = await ChestExeTable
                    .Where(a => a.ChestExe_ID == ID)
                    .ToListAsync();

                return chest_exelist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get chest_setrep list
        async public Task<Chest_SetRep> GetChest_setrepList(string ID)
        {
            try
            {
                chest_setreplist = await ChestSetRepTable
                    .Where(a => a.ChestSetRep_ID == ID)
                    .ToListAsync();

                return chest_setreplist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get chest_exesetrep list
        async public Task<ChestExe_ChestSetRep> GetChest_ExeSetRepList(string ID)
        {
            try
            {
                chest_exesetreplist = await ChestExeSetRepTable
                    .Where(a => a.ChestExeSetRepID == ID)
                    .ToListAsync();

                return chest_exesetreplist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get shoulder_exe list
        async public Task<Shoulder_Exe> GetShoulder_ExeList(string ID)
        {
            try
            {
                shoulder_exelist = await ShoulderExeTable
                    .Where(a => a.ShoulderExe_ID == ID)
                    .ToListAsync();

                return shoulder_exelist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get shoulder_setrep list
        async public Task<Shoulder_SetRep> GetShoulder_setrepList(string ID)
        {
            try
            {
                shoulder_setreplist = await ShoulderSetRepTable
                    .Where(a => a.ShoulderSetRep_ID == ID)
                    .ToListAsync();

                return shoulder_setreplist.First();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //get shoulder_exesetrep list
       async public Task<ShoulderExe_ShoulderSetRep> GetShoulder_exesetrepList(string ID)
       {
           try
           {
                shoulder_exesetreplist = await ShoulderExeSetRepTable
                    .Where (a=> a.ShoulderExeSetRepID == ID)
                    .ToListAsync();

                return shoulder_exesetreplist.First();
           }
           catch (Exception e)
           {
                return null;
           }
       }

        //Get exercise Program List
       async public Task<ExerciseProgram> GetExerciseProgramList(string ID)
       {
           try
           {
               ExerciseProgramList = await ExerciseProgramTable
                   .Where(a => a.ExerciseProgram_ID == ID)
                   .ToListAsync();

               return ExerciseProgramList.First();
           }
           catch (Exception e)
           {
               return null;
           }
       }

        //Get bicep_exe ID
       async public Task<string> GetBicepExe_ID(string r)
       {
           try
           {
               bicep_exesetreplist = await BicepExeSetRepTable.ToListAsync();

               return bicep_exesetreplist.Find(a => a.BicepExeSetRepID == r).BicepExeFK_ID;          
           }
           catch (Exception e)
           {
               return null;
           }
       }

        //Get bicep_setrep ID
       async public Task<string> GetBicep_SetRepID(string r)
       {
           try
           {
               bicep_exesetreplist = await BicepExeSetRepTable.ToListAsync();

               return bicep_exesetreplist.Find(a => a.BicepExeSetRepID == r).BicepSetRepFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

       //Get chest_exe ID
       async public Task<string> GetChestExe_ID(string r)
       {
           try
           {
               chest_exesetreplist = await ChestExeSetRepTable.ToListAsync();

               return chest_exesetreplist.Find(a => a.ChestExeSetRepID == r).ChestExeFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

       //Get chest_setrep ID
       async public Task<string> GetChest_SetRepID(string r)
       {
           try
           {
               chest_exesetreplist = await ChestExeSetRepTable.ToListAsync();

               return chest_exesetreplist.Find(a => a.ChestExeSetRepID == r).ChestSetRepFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

       //Get shoulder_exe ID
       async public Task<string> GetShoulderExe_ID(string r)
       {
           try
           {
               shoulder_exesetreplist = await ShoulderExeSetRepTable.ToListAsync();

               return shoulder_exesetreplist.Find(a => a.ShoulderExeSetRepID == r).ShoulderExeFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

       //Get shoulder_setrep ID
       async public Task<string> GetShoulder_SetRepID(string r)
       {
           try
           {
               shoulder_exesetreplist = await ShoulderExeSetRepTable.ToListAsync();

               return shoulder_exesetreplist.Find(a => a.ShoulderExeSetRepID == r).ShoulderSetRepFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

        //Get ExerciseProgram_Bicep ID
       async public Task<string> GetEPbicep_SetRepID(string r)
       {
           try
           {
               ExerciseProgramList = await ExerciseProgramTable
                   .ToListAsync();

               return ExerciseProgramList.Find(a => a.ExerciseProgram_ID == r).BicepExeSetRepFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

       //Get ExerciseProgram_Chest ID
       async public Task<string> GetEPchest_SetRepID(string r)
       {
           try
           {
               ExerciseProgramList = await ExerciseProgramTable.ToListAsync();

               return ExerciseProgramList.Find(a => a.ExerciseProgram_ID == r).ChestExeSetRepFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

       //Get ExerciseProgram_Shoulder ID
       async public Task<string> GetEPshoulder_SetRepID(string r)
       {
           try
           {
               ExerciseProgramList = await ExerciseProgramTable.ToListAsync();

               return ExerciseProgramList.Find(a => a.ExerciseProgram_ID == r).ShoulderExeSetRepFK_ID;
           }
           catch (Exception e)
           {
               return null;
           }
       }

    }
}
