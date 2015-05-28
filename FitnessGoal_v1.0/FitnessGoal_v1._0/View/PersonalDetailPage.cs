using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class PersonalDetailPage : ContentPage
    {
        public PersonalDetailPage()
        {

            Title = "Personal Detail";

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
            StackLayout test = new StackLayout() 
            {
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = StaticAppStyle.MenuColour,
                Children =
                {
                    new Label
                    {
                        Text = "Gender:",
                        FontSize = 16,
                        TextColor = Color.White
                    },

                    new Switch 
                    {
                        HorizontalOptions = LayoutOptions.EndAndExpand,
                        VerticalOptions = LayoutOptions.EndAndExpand,
                    }
                }
                 
            };

            StackLayout layout3 = new StackLayout()
            {
                //Padding = new Thickness(60, 60, 60, 60),
                
                Orientation = StackOrientation.Horizontal,
                HeightRequest = 150,
                WidthRequest = 150,
                Padding = new Thickness(0, 30, 0, 0),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
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

            StackLayout layoutALL = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Start
                
            };

            Entry dob = new Entry()
            {
                Placeholder = "D.O.B",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };

            Entry Waist = new Entry()
            {
                Placeholder = "Waist Measurement",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };

            Entry Hip = new Entry()
            {
                Placeholder = "Hip Measurement",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };

            Entry forearm = new Entry()
            {
                Placeholder = "Forearm Measurement",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };

            Entry height = new Entry()
            {
                Placeholder = "Height Measurement",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };

            Entry weight = new Entry()
            {
                Placeholder = "Weight Measurement",
                TextColor = Color.Black,
                BackgroundColor = Color.White
            };

            //SwitchCell Gender = new SwitchCell() 
            //{
            //    Text = "Gender",
                
            //};

            Button savebtn = new Button() 
            {
                Text = "Save",
                Style = StaticAppStyle.Button01,
            };

            savebtn.Clicked += async (sender, e) => 
            {
                var answer = await DisplayAlert("Personal Detail", "Confirm?", "Not Fuck given", "Yes");
                //Debug.WriteLine("Personal Detail saved"); // writes true or false to the console
            };

            //Entry Gender = new Entry()
            //{
            //    Placeholder = "Gender",
            //    TextColor = Color.Black,
            //    BackgroundColor = Color.White
            //};  

            //layout2.Children.Add(layout3);
            layout2.Children.Add(layout1);
            //test.Children.Add(lblgender);
            //test.Children.Add(Gender);
            layout2.Children.Add(test);
            layout2.Children.Add(dob);
            layout2.Children.Add(Hip);
            layout2.Children.Add(Waist);
            layout2.Children.Add(forearm);
            layout2.Children.Add(height);
            layout2.Children.Add(weight);
            layout2.Children.Add(savebtn);
           // layoutALL.Children.Add(layout1);
            layoutALL.Children.Add(layout3);
            layoutALL.Children.Add(layout2);

            Content = layoutALL;
            
        }
    }
}
