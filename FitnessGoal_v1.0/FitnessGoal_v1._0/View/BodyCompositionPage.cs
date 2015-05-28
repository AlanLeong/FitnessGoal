using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class BodyCompositionPage : ContentPage
    {
        public BodyCompositionPage()
        {
            Title = "Body Composition";

            StackLayout layout1 = new StackLayout()
            {
                Padding = new Thickness(40, 0, 40, 0),
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = StaticAppStyle.MenuColour,
                Children = 
                {
                    new Label()
                    {

                        Text = "Username",
                        TextColor = Color.White,
                        VerticalOptions = LayoutOptions.FillAndExpand,
                        HorizontalOptions = LayoutOptions.FillAndExpand,
                        XAlign = TextAlignment.Center,
                        YAlign = TextAlignment.Center,
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
                
                Orientation = StackOrientation.Horizontal,
                HeightRequest = 80,
                WidthRequest = 80,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = StaticAppStyle.MenuColour,
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
                VerticalOptions = LayoutOptions.Center

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

            Label lblbmi = new Label() 
            {
                //BMI = [Weight (KG) / Height (M) x Height (M)]
                BackgroundColor = StaticAppStyle.ThemeColor,
                Text = "Body Mass Index (BMI)",
                FontAttributes = FontAttributes.Bold,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Green
                
            };

            Label lblbfw = new Label() 
            {
                //
                BackgroundColor = StaticAppStyle.ThemeColor,
                Text = "Body Fat Percentage (BFP)",
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
                FontAttributes = FontAttributes.Bold,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                TextColor = Color.Green
            };

            Button Savebtn = new Button()
            {
                Text = "Save",
                Style = StaticAppStyle.Button01,
            };

            layout2.Children.Add(layout1);
            layout2.Children.Add(lblbmi);
            layout2.Children.Add(lblbfw);
            layout2.Children.Add(Hip);
            layout2.Children.Add(Waist);
            layout2.Children.Add(forearm);
            layout2.Children.Add(height);
            layout2.Children.Add(weight);
            layout2.Children.Add(Savebtn);
            
            layoutALL.Children.Add(layout3);
            layoutALL.Children.Add(layout2);

            Content = layoutALL;
                                   
        }

        //public async void Savebtn_Clicked(object sender, EventArgs args) 
        //{
        //    float hip, waist, forearm, height, weight, bmi, bfw;
        //    string sbmi, sbfw;

            
        //}
    }
}
