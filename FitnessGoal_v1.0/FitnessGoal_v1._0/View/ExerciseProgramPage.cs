using FitnessGoal_v1._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class ExerciseProgramPage : ContentPage
    {
        public static Registration register;
        LoginViewModel lvm = new LoginViewModel();
        BodyCompositionViewModel bcvm = new BodyCompositionViewModel();
        ExerciseProgramViewModel epvm = new ExerciseProgramViewModel();

        public ExerciseProgramPage()
        {
            Title = "Exercise Program";

            StackLayout layout1 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand
                
            };

            Label ExerciseProgramTitle = new Label
            {
                Text = "Exercise Program 1",
                Style = StaticAppStyle.LabelStyle,
                //TextColor = Color.White,
                FontSize = 20
            };

            Label cardio = new Label 
            {
                Text = "Cardio 30mins",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20
            };

            Label bicep = new Label
            {
                Text = "Bicep - Dumbell Curl - 4sets - 6 reps - 15kg",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20
            };

            Label chest = new Label
            {
                Text = "Chest - Bench Press - 4sets - 6 reps - 15kg",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20
            };

            Label shoulder = new Label
            {
                Text = "Shoulder - Incline Presss - 4sets - 6 reps - 15kg",
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

            layout1.Children.Add(ExerciseProgramTitle);
            layout1.Children.Add(cardio);
            layout1.Children.Add(bicep);
            layout1.Children.Add(chest);
            layout1.Children.Add(shoulder);
            layout2.Children.Add(settime);
            layout2.Children.Add(time);
            layout1.Children.Add(layout2);
            layout1.Children.Add(getexercisebtn);
            Content = layout1;
        }

        public async void testbtn_Clicked(object sender, EventArgs args)
        {
            try
            {
                int x;
                x = await epvm.ValidateExerciseProgram(StaticClass.RegistrationID);
                
            }
            catch (Exception e)
            {
                throw;
            }
        }

    }
}
