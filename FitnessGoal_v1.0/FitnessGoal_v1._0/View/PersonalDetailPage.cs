using FitnessGoal_v1._0.Model;
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
        public static Registration register;
        public static PersonalDetailModel pdm;
        public static BodyCompositionModel bcm;
        PersonalDetailViewModel pdvm = new PersonalDetailViewModel();

        Entry Eage = new Entry()
        {
            Placeholder = "Age",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry EWaist = new Entry()
        {
            Placeholder = "Waist Measurement",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry EHip = new Entry()
        {
            Placeholder = "Hip Measurement",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry Eforearm = new Entry()
        {
            Placeholder = "Forearm Measurement",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry Eheight = new Entry()
        {
            Placeholder = "Height Measurement",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry Eweight = new Entry()
        {
            Placeholder = "Weight Measurement",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry EGender = new Entry()
        {
            Placeholder = "Gender",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry EEmail = new Entry()
        {
            Placeholder = "Email",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        }; 

        public PersonalDetailPage()
        {

            Title = "Personal Detail";

            var scroll = new ScrollView();

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

            Button savebtn = new Button()
            {
                Text = "Save",
                Style = StaticAppStyle.Button01,
            };

            layout2.Children.Add(layout1);
            layout2.Children.Add(EGender);
            layout2.Children.Add(EEmail);
            layout2.Children.Add(Eage);
            layout2.Children.Add(EHip);
            layout2.Children.Add(EWaist);
            layout2.Children.Add(Eforearm);
            layout2.Children.Add(Eheight);
            layout2.Children.Add(Eweight);
            layout2.Children.Add(savebtn);
            layoutALL.Children.Add(layout3);
            layoutALL.Children.Add(layout2);

            scroll.Content = layoutALL;
            Content = scroll;

            savebtn.Clicked += savebtn_Clicked;
        }

        public async void savebtn_Clicked(object sender, EventArgs args)
        {
            //register = new Registration
            //{
            //   email = EEmail.Text
            //};

            pdm = new PersonalDetailModel 
            {
                age = Convert.ToInt32(Eage.Text),
                gender = EGender.Text
            };

            bcm = new BodyCompositionModel 
            {
                hip = Convert.ToDouble(EHip.Text),
                waist = Convert.ToDouble(EWaist.Text),
                forearm = Convert.ToDouble(Eforearm.Text),
                weight = Convert.ToDouble(Eweight.Text),
                height = Convert.ToDouble(Eheight.Text)
            };

            //not yet add EEmail.Text
            if(EHip.Text.Equals("") || EWaist.Text.Equals("") || Eforearm.Text.Equals("")
                || Eweight.Text.Equals("") || Eheight.Text.Equals("") || Eage.Text.Equals(""))
            {
                await DisplayAlert("Alert","Entry is not completed","Close");
            }
            else if (EGender.Text != "M" || EGender.Text != "F" || EGender.Text.Equals(""))
            {
                await DisplayAlert("Alert", "Please enter gender\n'M' = Male\n'F' = Female", "Close");
            }
            else 
            {
                try 
                {
                    bool x;
                    x = await pdvm.AddPersonalDetail(pdm, bcm);
                    if (x == true)
                    {
                        await DisplayAlert("Personal Detail", "Detail Saved", "Close");
 
                    }else
                        await DisplayAlert ("Alert","Failed to save","Close");
                    
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}