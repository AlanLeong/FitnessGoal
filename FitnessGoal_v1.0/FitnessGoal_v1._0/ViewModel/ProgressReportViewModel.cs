using System;
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
    class ProgressReportViewModel
    {
        private MobileServiceClient client;
        private IMobileServiceTable<ProgressReport> ProgressReportTable;
        private IMobileServiceTable<Registration> RegistrationTable;
        private IMobileServiceTable<BodyComposition> BodyCompositionTable;

        public List<ProgressReport> progressreportList { get; private set; }
        public List<Registration> registrationList { get; private set; }
        public List<BodyComposition> bodycompositionList { get; private set; }

        public ProgressReportViewModel()
        {
            client = new MobileServiceClient("https://fitnessgoal.azure-mobile.net/", "rymfMTjetjFCIgfWZDoOeDDysCxhKc10");
            BodyCompositionTable = client.GetTable<BodyComposition>();
            RegistrationTable = client.GetTable<Registration>();
            ProgressReportTable = client.GetTable<ProgressReport>();
        }

        //Insert BMI, registration ID into progress report table
        async public void AddReport(ProgressReport pr)
        {
            try
            {
                await ProgressReportTable.InsertAsync(pr);
                //return true;
            }
            catch (Exception e)
            {
                //return false;
            }
        }

        //get last 3 list from progress report table
        async public Task<List<ProgressReport>> GetProgressReportList(string ID)
        {
            try
            {
                progressreportList = await ProgressReportTable
                    .Where(a => a.RegistrationFK_ID == ID)
                    .OrderByDescending( a=> a.dateCreated)
                    .ToListAsync();

                return progressreportList;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
