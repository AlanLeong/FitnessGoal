using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class MyProfilePage : ContentPage
    {
        //public static Registration login;
        public MyProfilePage()
        {
            Title = "My Profile";

            StackLayout layout1 = new StackLayout() 
            {
                Padding = new Thickness(40, 0, 40, 0),
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = StaticAppStyle.MenuColour,
                Children = 
                {
                    new Label()
                    {

                        Text = Registration.Current,
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        XAlign = TextAlignment.Center,
                        YAlign = TextAlignment.Center,
                        //Style = TextAlignment.Center,
                        //Style = StaticAppStyle.LabelStyle,
                        //BackgroundColor = StaticAppStyle.MenuColour,
                        FontSize = 18
                    }
                }
            };

            StackLayout layout2 = new StackLayout() 
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(40, 0, 40, 0)
            };

            StackLayout layout3 = new StackLayout()
            {
                //Padding = new Thickness(60, 60, 60, 60),
                
                Orientation = StackOrientation.Horizontal,
                HeightRequest = 150,
                WidthRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(0, 30, 0, 0),
                Children = 
                {
                    new Image
                    {
                      //Will take pic from databse
                      Source = ImageSource.FromFile("UserDetail.png"),
                      Aspect = Aspect.AspectFit
                    
                    }
                }
            };

            StackLayout layoutbmi = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal
                //HorizontalOptions = LayoutOptions.Center,
                //VerticalOptions = LayoutOptions.Center

            };

            StackLayout layoutALL = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Start

            };

            Button btnBMI = new Button()
            {
                Text = "User BMI",
                Style = StaticAppStyle.Button01,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Button btnBFP = new Button()
            {
                Text = "User BFP",
                Style = StaticAppStyle.Button01,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Label lbltargetBMI = new Label()
            {
                Text = "User BMI GOAL",
                TextColor = Color.Blue,
                BackgroundColor = Color.White,
                XAlign = TextAlignment.Center
            };

            Label lbltargetBFP = new Label()
            {
                Text = "User BFP GOAL",
                TextColor = Color.Blue,
                BackgroundColor = Color.White,
                XAlign = TextAlignment.Center
            };

            Label lblGender = new Label()
            {
                Text = "Male",
                TextColor = Color.Blue,
                BackgroundColor = Color.White,
                XAlign = TextAlignment.Center
            };

            Label lbldob = new Label()
            {
                Text = "22",
                TextColor = Color.Blue,
                BackgroundColor = Color.White,
                XAlign = TextAlignment.Center,
            };

            
            layout2.Children.Add(layout1);
            layout2.Children.Add(lblGender);
            layout2.Children.Add(lbldob);
            layoutbmi.Children.Add(btnBMI);
            layoutbmi.Children.Add(btnBFP);
            layout2.Children.Add(layoutbmi);
            layout2.Children.Add(lbltargetBMI);
            layout2.Children.Add(lbltargetBFP);
           
            layoutALL.Children.Add(layout3);
            layoutALL.Children.Add(layout2);

            Content = layoutALL;

            btnBMI.Clicked += btnBMI_Clicked;
            btnBFP.Clicked += btnBFP_Clicked;
            
        }

        public async void btnBMI_Clicked(object sender, EventArgs args)
        {
            await DisplayAlert("Body Mass Index", 
              "Category                   BMI Range\n"
            + "Underweight             Below 18.5\n"
            + "Healthy                     18.6 - 24.9\n"
            + "Overweight               25.0 - 29.9\n"
            + "Obese                       30.0 - 39.9\n"
            + "High Risk Obesity    Above 40\n", "Close");

        }

        public async void btnBFP_Clicked(object sender, EventArgs args)
        {
            await DisplayAlert("Body Fat Percentage", "Invalid username or password", "Close");

        }

    }
}
