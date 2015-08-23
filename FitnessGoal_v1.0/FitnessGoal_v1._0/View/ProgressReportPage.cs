using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class ProgressReportPage : ContentPage
    {
        ProgressReportViewModel prvm = new ProgressReportViewModel();
        ListView ProgressReportListView = new ListView();
        List<ProgressReport> prl = new List<ProgressReport>();

        public ProgressReportPage()
        {
            getData();
            Title = "Progress Report";
            ProgressReportListView.RowHeight = 60;
            ProgressReportListView.ItemTemplate = new DataTemplate(typeof(ProgressReportViewCell));
            this.Content = new StackLayout()
            {
                Children =
                {
                    ProgressReportListView
                }
            };
        }

        private async void getData()
        {
            prl = await prvm.GetProgressReportList(StaticClass.RegistrationID);
            ProgressReportListView.ItemsSource = prl;
        }

    }
}
