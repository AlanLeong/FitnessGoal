using FitnessGoal_v1._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;
using FitnessGoal_v1._0.Model;

namespace FitnessGoal_v1._0
{
    public class ExerciseProgramPage : ContentPage
    {
        public static Registration register;
        public static Registration register1;
        public static BodyComposition bcm;
        public static ExerciseProgramModel epm;
        public static Bicep_Exe bem;
        public static Bicep_SetRep bsr;
        public static BicepExe_BicepSetRep besr;
        public static Chest_Exe cem;
        public static Chest_SetRep csr;
        public static ChestExe_ChestSetRep cesr;
        public static Shoulder_Exe sem;
        public static Shoulder_SetRep ssr;
        public static ShoulderExe_ShoulderSetRep sesr;


        LoginViewModel lvm = new LoginViewModel();
        BodyCompositionViewModel bcvm = new BodyCompositionViewModel();
        ExerciseProgramViewModel epvm = new ExerciseProgramViewModel();

        Label lblbicep = new Label
        {
            Text = "",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblchest = new Label
        {
            Text = "",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblshoulder = new Label
        {
            Text = "",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        public ExerciseProgramPage()
        {
            getExerciseProgramDetail();

            Title = "Exercise Program";

            StackLayout layout1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand
                
            };

            Label lblExerciseProgramTitle = new Label
            {
                Text = "Exercise Program",
                Style = StaticAppStyle.LabelStyle,
                //TextColor = Color.White,
                FontSize = 20
            };

            Label lblcardio = new Label 
            {
                Text = "Cardio 30mins",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20
            };


            TimePicker time = new TimePicker { };

            Label settime = new Label 
            {
                Text = "Set Alarm:",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 16
            };

            StackLayout layout2 = new StackLayout 
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Fill,
                HorizontalOptions = LayoutOptions.Fill
            };

            Button getexercisebtn = new Button()
            {
                Style = StaticAppStyle.Button01,
                Text = "Get Exercise! ",

            };

            layout1.Children.Add(lblExerciseProgramTitle);
            layout1.Children.Add(lblcardio);
            layout1.Children.Add(lblbicep);
            layout1.Children.Add(lblchest);
            layout1.Children.Add(lblshoulder);
            layout2.Children.Add(settime);
            layout2.Children.Add(time);
            layout1.Children.Add(layout2);
            layout1.Children.Add(getexercisebtn);
            Content = layout1;

            getexercisebtn.Clicked += getexercisebtn_Clicked;
        }

        public async void getexercisebtn_Clicked(object sender, EventArgs args)
        {
            try
            {
                int x;
                x = await epvm.ValidateExerciseProgram(StaticClass.RegistrationID);
                if (x > 0)
                {
                    //assign exercise program based on bmi
                    bcm = await bcvm.GetMyCompositionList(StaticClass.RegistrationID);
                    register1 = await lvm.GetRegistrationList(StaticClass.RegistrationID);

                    if (bcm.bmi > 25)
                    {
                        
                        //update registration table, to insert exercise program ID
                        register = new Registration
                        {
                            Registration_ID = StaticClass.RegistrationID,
                            username = register1.username,
                            password = register1.password,
                            email = register1.email,
                            ExerciseProgram_ID = "569B3B80-BD99-431C-A4E1-16F147895310"
                            
                        };
                        lvm.UpdateRegistration(register);
                        //Store all ID ID to static class
                        StaticClass.ExerciseProgramID = await lvm.GetProgramID(StaticClass.RegistrationID);
                        StaticClass.Bicep_ExeSetRepID = await epvm.GetEPbicep_SetRepID(StaticClass.ExerciseProgramID);
                        StaticClass.Chest_ExeSetRepID = await epvm.GetEPchest_SetRepID(StaticClass.ExerciseProgramID);
                        StaticClass.Shoulder_ExeSetRepID = await epvm.GetEPshoulder_SetRepID(StaticClass.ExerciseProgramID);
                        StaticClass.Bicep_ExeID = await epvm.GetBicepExe_ID(StaticClass.Bicep_ExeSetRepID);
                        StaticClass.Bicep_SetRepID = await epvm.GetBicep_SetRepID(StaticClass.Bicep_ExeSetRepID);

                        StaticClass.Chest_ExeID = await epvm.GetChestExe_ID(StaticClass.Chest_ExeSetRepID);
                        StaticClass.Chest_SetRepID = await epvm.GetChest_SetRepID(StaticClass.Chest_ExeSetRepID);

                        StaticClass.Shoulder_ExeID = await epvm.GetShoulderExe_ID(StaticClass.Shoulder_ExeSetRepID);
                        StaticClass.Shoulder_SetRepID = await epvm.GetShoulder_SetRepID(StaticClass.Shoulder_ExeSetRepID);
                        await DisplayAlert("Alert", "Inserted Exercise ID ", "Close");

                    }
                    else if (bcm.bmi > 18.6 && bcm.bmi < 24.9)
                    {
                        await DisplayAlert("Alert", "BMI 18.6 - 24.9", "Close");
                        //update registration table, to insert exercise program ID
                        register = new Registration
                        {
                            Registration_ID = StaticClass.RegistrationID,
                            ExerciseProgram_ID = "6B9F3E73-0F67-4421-A666-7A2384068222 "
                        };
                        lvm.UpdateRegistration(register);
                    }
                    else if (bcm.bmi < 18.5)
                    {
                        await DisplayAlert("Alert", "BMI < 18.5", "Close");
                        //update registration table, to insert exercise program ID
                        register = new Registration
                        {
                            Registration_ID = StaticClass.RegistrationID,
                            ExerciseProgram_ID = "569B3B80-BD99-431C-A4E1-16F147895310"
                        };
                        lvm.UpdateRegistration(register);
                    }
                    else 
                    {
                        await DisplayAlert("Alert", "Unknown Error", "Close");
                    }
                    
                }
                else
                {
                    //prompt user to personal detail page to insert data
                    await DisplayAlert("Alert", "Personal Details not found", "Close");
                    await Navigation.PushModalAsync(new PersonalDetailPage());
                }
                
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async void getExerciseProgramDetail()
        {
            //get all the list
            epm = await epvm.GetExerciseProgramList(StaticClass.ExerciseProgramID);
            bem = await epvm.GetBicep_ExeList(StaticClass.Bicep_ExeID);
            bsr = await epvm.GetBicep_setrepList(StaticClass.Bicep_SetRepID);
            cem = await epvm.GetChest_ExeList(StaticClass.Chest_ExeID);
            csr = await epvm.GetChest_setrepList(StaticClass.Chest_SetRepID);
            sem = await epvm.GetShoulder_ExeList(StaticClass.Shoulder_ExeID);
            ssr = await epvm.GetShoulder_setrepList(StaticClass.Shoulder_SetRepID);

            lblbicep.BindingContext = bem;
            lblbicep.SetBinding(Label.TextProperty, "TypeofExercise");

        }

    }
}
