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
        LoginViewModel lvm = new LoginViewModel();
        float bmi, bfp, f1, f2, f3, f4, f5, leanbodymass, bodyfatweight;

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
                Style = StaticAppStyle.Button01
            };

            //for testing
            Button testbtn = new Button()
            {
                Text = "Test",
                Style = StaticAppStyle.Button01
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
            layout2.Children.Add(testbtn);
            layoutALL.Children.Add(layout3);
            layoutALL.Children.Add(layout2);

            scroll.Content = layoutALL;
            Content = scroll;

            savebtn.Clicked += savebtn_Clicked;
            testbtn.Clicked += textbtn_Clicked;
        }

        //testing
        public async void textbtn_Clicked(object sender, EventArgs args)
        {
            StaticClass.RegistrationID = await lvm.GetuserID(Registration.Current);
            //StaticClass.PersonalDetailID = await pdvm.GetPersonalDetailID(pdm);
            await DisplayAlert("Testing", StaticClass.RegistrationID , "Close");
        
        }

        public async void savebtn_Clicked(object sender, EventArgs args)
        {
            //to calculate bfp
            if (EGender.Text.Equals("M"))
            {
                //calculate bfp male
                f1 = (Convert.ToSingle(Eweight.Text) * 1.082f) + 94.42f;
                f2 = Convert.ToSingle(EWaist.Text) * 4.15f;
                leanbodymass = f1 - f2;
                bodyfatweight = Convert.ToSingle(Eweight.Text) - leanbodymass;
                bfp = (bodyfatweight * 100) / Convert.ToSingle(Eweight.Text);
            }
            else if (EGender.Text.Equals("F"))
            {
                //calculate bfp female
                f1 = (Convert.ToSingle(Eweight.Text) * 0.732f) + 8.987f;
                f2 = Convert.ToSingle(EWaist.Text) / 3.140f;
                f3 = Convert.ToSingle(EHip.Text) * 0.434f;
                f4 = Convert.ToSingle(Eforearm.Text) * 0.434f;
                leanbodymass = f1 + f2 - f3 + f5;
                bfp = (bodyfatweight * 100) / Convert.ToSingle(Eweight.Text);
            }

            //Validation 
            if(EHip.Text.Equals("") || EWaist.Text.Equals("") || Eforearm.Text.Equals("")
                || Eweight.Text.Equals("") || Eheight.Text.Equals("") || Eage.Text.Equals(""))
            {
                await DisplayAlert("Alert","Entry is not completed","Close");
            }
            //else if (!EGender.Text.Equals("M") || !EGender.Text.Equals("F") || EGender.Text.Equals(""))
            //{
            //    await DisplayAlert("Alert", "Please enter gender\n'M' = Male\n'F' = Female", "Close");
            //}
            
            else
            {
                //start putting data into list after validation
                pdm = new PersonalDetailModel
                {
                    age = Convert.ToInt32(Eage.Text),
                    gender = EGender.Text,
                    RegistrationFK_ID = StaticClass.RegistrationID
                };

                //calculate bmi
                bmi = Convert.ToSingle(Eweight.Text) / Convert.ToSingle(Eheight.Text) * Convert.ToSingle(Eweight.Text);

                bcm = new BodyCompositionModel
                {
                    hip = Convert.ToSingle(EHip.Text),
                    waist = Convert.ToSingle(EWaist.Text),
                    forearm = Convert.ToSingle(Eforearm.Text),
                    weight = Convert.ToSingle(Eweight.Text),
                    height = Convert.ToSingle(Eheight.Text),
                    bmi = bmi,
                    bfp = bfp,
                    RegistrationFK_ID = StaticClass.RegistrationID
                };

                try
                {
                    bool x;
                    x = await pdvm.AddPersonalDetail(pdm, bcm);
                    if (x == true)
                    {
                        await DisplayAlert("Personal Detail", "Detail Saved", "Close");

                    }
                    else
                        await DisplayAlert("Alert", "Failed to save", "Close");

                }
                catch (Exception e)
                {
                    throw;
                }
            }      
        }
    }
}