using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class NavigationMenu : ContentPage
    {
        public ListView Menu { get; set; }
        public NavigationMenu()
        {
            
            Icon = "Menu.png";
            Title = "Home";
            BackgroundColor = StaticAppStyle.ThemeColor;

            Menu = new MenuListView();

            StackLayout user = new StackLayout()
            {
                Padding = new Thickness(25, 25, 25, 25),
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = StaticAppStyle.MenuColour,
                Children = 
                {
                    new Image
                    {
                      //Will take pic from databse
                      Source = ImageSource.FromFile("User.png"),
                      Aspect = Aspect.AspectFit
                    
                    },

                    new Label()
                    {
                        Text = Registration.Current,
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.Center,
                        BackgroundColor = Color.Transparent,
                        FontSize = 18,          
                    },

                    new Button()
                    {
                        Text = "logout",
                        TextColor = Color.White,
                        HorizontalOptions = LayoutOptions.End,
                        VerticalOptions = LayoutOptions.End,
                        FontSize = 19,
                        //Command = new Command(() => Navigation.PushModalAsync(new LoginPages()))
                        Command = new Command(() => Clear())
                        
                    }
                }
            };

            StackLayout layout = new StackLayout
            {
                VerticalOptions = LayoutOptions.Fill
            };

            layout.Children.Add(user);
            layout.Children.Add(Menu);

            Content = layout;
        }

        private void Clear()
        {
            StaticClass.RegistrationID = null;
            StaticClass.PersonalDetailID = null;
            StaticClass.BodyCompositionID = null;
            StaticClass.ProgressReportID = null;
            StaticClass.ExerciseProgramID = null;
            StaticClass.Bicep_ExeID = null;
            StaticClass.Bicep_SetRepID = null;
            StaticClass.Bicep_ExeSetRepID = null;
            StaticClass.Chest_ExeID = null;
            StaticClass.Chest_SetRepID = null;
            StaticClass.Chest_ExeSetRepID = null;
            StaticClass.Shoulder_ExeID = null;
            StaticClass.Shoulder_SetRepID = null;
            StaticClass.Shoulder_ExeSetRepID = null;
            StaticClass.biceplbl = null;
            StaticClass.chestlbl = null;
            StaticClass.shoulderlbl = null;
            Navigation.PushModalAsync(new LoginPages());
        }
    }
}
