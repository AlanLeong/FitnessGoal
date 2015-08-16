using FitnessGoal_v1._0.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class HomePage : ContentPage
    {
        public static Registration login;
        LoginViewModel LVM = new LoginViewModel();
        BodyCompositionViewModel bdvm = new BodyCompositionViewModel();
        PersonalDetailViewModel pdvm = new PersonalDetailViewModel();
        ExerciseProgramViewModel epvm = new ExerciseProgramViewModel();

        public HomePage()
        {
            //getstaticclass();
            Title = "Home Page";

            StackLayout layout1 = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.White
            };

            Label quote = new Label() 
            {
                Text = "Feel Sore Today or Feel Sorry Tomorrow",
                Style = StaticAppStyle.LabelStyle,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Bold
                
            };

            layout1.Children.Add(quote);

            Content = layout1;

        }
    }
}
