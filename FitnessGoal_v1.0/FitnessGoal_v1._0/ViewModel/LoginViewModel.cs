using System;
//for azure mobile service
using Microsoft.WindowsAzure.MobileServices; 
//for multithreading
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace FitnessGoal_v1._0
{
    public class LoginViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<Registration> registrationTable;
        private IMobileServiceTable<ExerciseProgramModel> ExerciseProgramTable;

        //Create list for user
        public List<Registration> registrationList { get; private set; }
        public List<ExerciseProgramModel> ExerciseProgramList { get; private set; }

        public LoginViewModel() 
        {
            registrationList = new List<Registration>();

            //Connect to Azure Mobile Service
            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            registrationTable = client.GetTable<Registration>();
            ExerciseProgramTable = client.GetTable<ExerciseProgramModel>();
        }

        async public Task<int> ValidateLogin(Registration r)
        {
            try
            {
                registrationList = await registrationTable
                    .Where(login => login.username == r.username && login.password == r.password)
                    .ToListAsync();
                
                if (registrationList.Count > 0)
                {
                    Registration.Current = r.username;
                    Registration.IsUser = true;
                    //userid =  
                    return registrationList.Count;
                }
                else
                {
                    return registrationList.Count;
                } 
            }
            catch (Exception e) 
            {
               return 0;
            }
        }

        //Register/ Add info
        async public Task<int> Adduser(Registration r) 
        {
            try 
            {
                registrationList = await registrationTable
                    .Where(register => register.username == r.username)
                    .ToListAsync();

                if(registrationList.Count == 0)
                {
                    await registrationTable.InsertAsync(r);
                    return registrationList.Count;
                }
                else
                {
                    return registrationList.Count;
                }
                           
            }
            catch (Exception e)
            {

                return 0;
            }  
        }

        //to retrive UserId also known as RegistrationID PK in db to put in put in other table as FK
        async public Task<string> GetuserID (string r)
        {
            try
            {

                registrationList = await registrationTable.ToListAsync();

                return registrationList.Find(a => a.username == r).Registration_ID;
            }
            catch (Exception e)
            {
                return null;
            }
        }


        //Retrieve program ID
        //async public Task<string> GetProgramID(string r)
        //{
        //    try 
        //    {
        //        registrationList = await registrationTable.ToListAsync();

        //        return registrationList.Find(a => a.Registration_ID == r).ExerciseProgram_ID;
        //    }
        //    catch (Exception e)
        //    {
        //        return null;
        //    }
        //}
    }    
}
