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

            layout1.Children.Add(ExerciseProgramTitle);
            layout1.Children.Add(cardio);
            layout1.Children.Add(bicep);
            layout1.Children.Add(chest);
            layout1.Children.Add(shoulder);

            Content = layout1;
        }
    }
}
