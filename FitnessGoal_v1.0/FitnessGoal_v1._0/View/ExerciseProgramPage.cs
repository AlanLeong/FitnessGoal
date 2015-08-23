using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;
using FitnessGoal_v1._0;

namespace FitnessGoal_v1._0
{
    public class ExerciseProgramPage : ContentPage
    {
        public static Registration register;
        public static Registration register1;
        public static BodyComposition bcm;
        //public static ExerciseProgram epm;
        List<ExerciseProgram> epm = new List<ExerciseProgram>();
        public static Bicep_Exe bem;
        public static Bicep_SetRep bsr;
        public static BicepExe_BicepSetRep besr;
        public static Chest_Exe cem;
        public static Chest_SetRep csr;
        public static ChestExe_ChestSetRep cesr;
        public static Shoulder_Exe sem;
        public static Shoulder_SetRep ssr;
        public static ShoulderExe_ShoulderSetRep sesr;
        StringBuilder builderbicep = new StringBuilder();
        StringBuilder builderchest = new StringBuilder();
        StringBuilder buildershoulder = new StringBuilder();

        LoginViewModel lvm = new LoginViewModel();
        BodyCompositionViewModel bcvm = new BodyCompositionViewModel();
        ExerciseProgramViewModel epvm = new ExerciseProgramViewModel();


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

        Label lblbicep = new Label
        {
            Text = StaticClass.biceplbl,
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblchest = new Label
        {
            Text = StaticClass.chestlbl,
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblshoulder = new Label
        {
            Text = StaticClass.shoulderlbl,
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };
       
        public ExerciseProgramPage()
        {
            //getExerciseProgramDetail();
            Title = "Exercise Program";

            StackLayout layout1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand
                
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
            //layout2.Children.Add(settime);
            //layout2.Children.Add(time);
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
                        #region lui random code
                        //initiate the list
                        List<string> list = new List<string> 
                        {
                            "1CE7B96C-E86B-48CC-A8BD-615C1F47D6A1",
                            "E213D5C7-E7B6-4C03-B1EF-2BA1FEEDAD82",
                            "8A602155-DDD2-4AF3-94EC-733E4080C31C"
                        };

                        //get random item from list
                        Random indexGenerator = new Random();
                        int index = indexGenerator.Next(0, list.Count - 1);
                        string exeid = list.ElementAt(index);
                        #endregion

                        //update registration table, to insert exercise program ID
                        register = new Registration
                        {
                            Registration_ID = StaticClass.RegistrationID,
                            username = register1.username,
                            password = register1.password,
                            email = register1.email,
                            ExerciseProgram_ID = exeid
                            
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

                        //show exercise coding to label
                        getExerciseProgramDetail();

                        //navigate back to the same page (Act as refresh)
                        refresh();
                    }
                    else if (bcm.bmi > 18.6 && bcm.bmi < 24.9999)
                    {
                        //random exercise
                        #region lui random code
                        //initiate the list
                        List<string> list = new List<string> 
                        {
                            "6B9F3E73-0F67-4421-A666-7A2384068222",
                            "369F48BC-094F-4696-815D-9C24BD75DBED",
                            "B290FE02-2522-4AA7-B7D4-0CC7E02FBD41",
                            "BABDC510-1F36-43E9-BE0D-02834D5ACA8A",
                            "03D6FD9C-2C7F-470B-A6CB-982B45A36FBB",
                            "3F83A90F-A1B3-4153-B710-DCBBA8CFDC2A"
                        };

                        //get random item from list
                        Random indexGenerator = new Random();
                        int index = indexGenerator.Next(0, list.Count - 1);
                        string exeid = list.ElementAt(index);
                        #endregion

                        //update registration table, to insert exercise program ID
                        register = new Registration
                        {
                            Registration_ID = StaticClass.RegistrationID,
                            username = register1.username,
                            password = register1.password,
                            email = register1.email,
                            ExerciseProgram_ID = exeid
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

                        //show exercise coding to label
                        getExerciseProgramDetail();

                        //navigate back to the same page (Act as refresh)
                        refresh();
                    }
                    else if (bcm.bmi < 18.59999)
                    {
                        #region lui random code
                        //initiate the list
                        List<string> list = new List<string> 
                        {
                            "371E4009-E9C4-4246-8988-964709D3D2F0",
                            "4C94953F-2E70-4DDE-B0B2-91B464EC6074",
                            "569B3B80-BD99-431C-A4E1-16F147895310"
                        };

                        //get random item from list
                        Random indexGenerator = new Random();
                        int index = indexGenerator.Next(0, list.Count - 1);
                        string exeid = list.ElementAt(index);
                        #endregion

                        //update registration table, to insert exercise program ID
                        register = new Registration
                        {
                            Registration_ID = StaticClass.RegistrationID,
                            username = register1.username,
                            password = register1.password,
                            email = register1.email,
                            ExerciseProgram_ID = exeid
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

                        //show exercise coding to label
                        getExerciseProgramDetail();

                        //navigate back to the same page (Act as refresh)
                        refresh();
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

            builderbicep.Append(bem.TypeofExercise + " " + bsr.Set + "Sets " + bsr.Rep + "Reps " + bsr.Weight + "Kg");
            //string.Format("{0} {1} Sets {2} Reps {3} Kg", bem.TypeofExercise, bsr.Set, bsr.Rep, bsr.Weight);

            StaticClass.biceplbl = builderbicep.ToString();
            //StaticClass.biceplbl = string.Format("{0} {1} Sets {2} Reps {3} Kg", bem.TypeofExercise, bsr.Set, bsr.Rep, bsr.Weight);

            builderchest.Append(cem.TypeofExercise + " " + csr.Set + "Sets " + csr.Rep + "Reps " + csr.Weight + "Kg");

            StaticClass.chestlbl = builderchest.ToString();

            buildershoulder.Append(sem.TypeofExercise + " " + ssr.Set + "Sets " + ssr.Rep + "Reps " + ssr.Weight + "Kg");

            StaticClass.shoulderlbl = buildershoulder.ToString();
        }

        private void refresh()
        {
            Navigation.PushModalAsync(new MasterDetailHome());
        }
    }
}
