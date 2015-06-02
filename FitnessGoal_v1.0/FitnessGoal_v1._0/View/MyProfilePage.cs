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
        PersonalDetailViewModel pdvm = new PersonalDetailViewModel();
        BodyCompositionViewModel bcvm = new BodyCompositionViewModel();

        PersonalDetail pd = new PersonalDetail();
        BodyComposition bc = new BodyComposition();

        Label lblBMI = new Label()
        {
            Text = "User BMI",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20,
            BackgroundColor = StaticAppStyle.ThemeColor
        };

        Label lblBFP = new Label()
        {
            Text = "User BFP",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20,
            BackgroundColor = StaticAppStyle.ThemeColor
        };

        Label lbltargetBMI = new Label()
        {
            Text = "BMI GOAL",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20,
            BackgroundColor = StaticAppStyle.ThemeColor
        };

        Label lbltargetBFP = new Label()
        {
            Text = "BFP GOAL",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20,
            BackgroundColor = StaticAppStyle.ThemeColor
        };

        Label lblGender = new Label()
        {
            Text = "Gender",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20,
            BackgroundColor = StaticAppStyle.ThemeColor
        };

        Label lblage = new Label()
        {
            Text = "Age",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20,
            BackgroundColor = StaticAppStyle.ThemeColor
        };

        Label lblgetage = new Label()
        {
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblgetgender = new Label()
        {
            //Text = "Get Gender",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblgetbmi = new Label()
        {
            //Text = "Get BMI",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblgetbfp = new Label()
        {
            //Text = "Get BFP",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblGetBMIGoal = new Label()
        {
            Text = "18.6-24.9 (Kg/m2)",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };

        Label lblGetBFPGoal = new Label()
        {
            Text = "8-19 %",
            Style = StaticAppStyle.LabelStyle2,
            FontSize = 20
        };


        //public static Registration login;
        public MyProfilePage()
        {
            getprofile();

            Title = "My Profile";

            StackLayout imagelayout = new StackLayout()
            {
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
                      Source = ImageSource.FromFile("UserDetail.png"),
                      Aspect = Aspect.AspectFit
                    
                    }
                }
            };

            StackLayout main = new StackLayout 
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(30,0,30,0)
            };

            StackLayout vertical1 = new StackLayout 
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };

            StackLayout vertical2 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };

            StackLayout vertical3 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };

            StackLayout vertical4 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };

            StackLayout vertical5 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };

            StackLayout vertical6 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };


            Label username = new Label 
            {
                Text = Registration.Current,
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.MenuColour,
                TextColor = Color.White
            };

            vertical1.Children.Add(lblage);
            vertical1.Children.Add(lblgetage);
            vertical2.Children.Add(lblGender);
            vertical2.Children.Add(lblgetgender);
            vertical3.Children.Add(lblBMI);
            vertical3.Children.Add(lblgetbmi);
            vertical4.Children.Add(lblBFP);
            vertical4.Children.Add(lblgetbfp);
            vertical5.Children.Add(lbltargetBMI);
            vertical5.Children.Add(lblGetBMIGoal);
            vertical6.Children.Add(lbltargetBFP);
            vertical6.Children.Add(lblGetBFPGoal);
            main.Children.Add(imagelayout);
            main.Children.Add(username);
            main.Children.Add(vertical1);
            main.Children.Add(vertical2);
            main.Children.Add(vertical3);
            main.Children.Add(vertical4);
            main.Children.Add(vertical5);
            main.Children.Add(vertical6);

            var scroll = new ScrollView();

            scroll.Content = main;
            Content = scroll;
        }

        //public async void btnBMI_Clicked(object sender, EventArgs args)
        //{
        //    await DisplayAlert("Body Mass Index", 
        //      "Category                   BMI Range\n"
        //    + "Underweight             Below 18.5\n"
        //    + "Healthy                     18.6 - 24.9\n"
        //    + "Overweight               25.0 - 29.9\n"
        //    + "Obese                       30.0 - 39.9\n"
        //    + "High Risk Obesity    Above 40\n", "Close");

        //}

        public async void getprofile()
        {
           pd = await pdvm.GetMyProfileList(StaticClass.RegistrationID);
           bc = await bcvm.GetMyCompositionList(StaticClass.RegistrationID);
           lblgetage.BindingContext = pd;
           lblgetage.SetBinding(Label.TextProperty, "age");
           lblgetgender.BindingContext = pd;
           lblgetgender.SetBinding(Label.TextProperty, "gender");
           lblgetbmi.BindingContext = bc;
           lblgetbmi.SetBinding(Label.TextProperty, "bmi");
           lblgetbfp.BindingContext = bc;
           lblgetbfp.SetBinding(Label.TextProperty, "bfp");

        }

    }
}
