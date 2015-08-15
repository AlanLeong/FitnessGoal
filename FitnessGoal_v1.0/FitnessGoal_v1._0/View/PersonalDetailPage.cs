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
        public static PersonalDetail pdm;
        public static BodyComposition bcm;
        PersonalDetailViewModel pdvm = new PersonalDetailViewModel();
        BodyCompositionViewModel bcvm = new BodyCompositionViewModel();
        LoginViewModel lvm = new LoginViewModel();
    
        float bmi, bfp, f1, f2, f3, f4, f5, leanbodymass, bodyfatweight, a;

        Entry Eage = new Entry()
        {
            Placeholder = "Age",
            Style = StaticAppStyle.EntryStyle
        };

        Entry EWaist = new Entry()
        {
            Placeholder = "Measurement",
            Style = StaticAppStyle.EntryStyle
        };

        Entry EHip = new Entry()
        {
            Placeholder = "Measurement",
            Style = StaticAppStyle.EntryStyle
        };

        Entry Eforearm = new Entry()
        {
            Placeholder = "Measurement",
            Style = StaticAppStyle.EntryStyle
        };

        Entry Eheight = new Entry()
        {
            Placeholder = "Measurement",
            Style = StaticAppStyle.EntryStyle
        };

        Entry Eweight = new Entry()
        {
            Placeholder = "Measurement",
            Style = StaticAppStyle.EntryStyle
        };

        Entry EGender = new Entry()
        {
            Placeholder = "Gender",
            Style = StaticAppStyle.EntryStyle
        };

        Entry EWaist2 = new Entry()
        {
            Placeholder = "Measurement",
            Style = StaticAppStyle.EntryStyle,
        }; 

        public PersonalDetailPage()
        {
            getPersonalDetail();

            Title = "Personal Detail";

            var scroll = new ScrollView();

            StackLayout layout1 = new StackLayout()
            {
                //Padding = new Thickness(40, 0, 40, 0),
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
                VerticalOptions = LayoutOptions.StartAndExpand,
                //Padding = new Thickness(30,0,30,0)

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

            StackLayout vertical7 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };

            StackLayout vertical8 = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal
            };

            Button savebtn = new Button()
            {
                Text = "Save",
                Style = StaticAppStyle.Button01
            };

             Button testbtn = new Button()
            {
                Text = "Submit",
                Style = StaticAppStyle.Button01
            };

            Button updatebtn = new Button() 
            {
                Text = "Update",
                Style = StaticAppStyle.Button01
            };

            Label lblage = new Label()
            {
                Text = "Age",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            Label lblgender = new Label()
            {
                Text = "Gender",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            Label lblhip = new Label()
            {
                Text = "Hip ",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            Label lblwaist = new Label()
            {
                Text = "Waist ",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            Label lblwaist2 = new Label()
            {
                Text = "Waist  *till naval",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            Label lblforearm = new Label()
            {
                Text = "Forearm ",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            Label lblheight = new Label()
            {
                Text = "Height ",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            Label lblweight = new Label()
            {
                Text = "Weight ",
                Style = StaticAppStyle.LabelStyle2,
                FontSize = 20,
                BackgroundColor = StaticAppStyle.ThemeColor
            };

            vertical1.Children.Add(lblgender);
            vertical1.Children.Add(EGender);
            vertical2.Children.Add(lblage);
            vertical2.Children.Add(Eage);
            vertical3.Children.Add(lblhip);
            vertical3.Children.Add(EHip);
            vertical4.Children.Add(lblwaist);
            vertical4.Children.Add(EWaist);
            vertical5.Children.Add(lblwaist2);
            vertical5.Children.Add(EWaist2);
            vertical6.Children.Add(lblforearm);
            vertical6.Children.Add(Eforearm);
            vertical7.Children.Add(lblheight);
            vertical7.Children.Add(Eheight);
            vertical8.Children.Add(lblweight);
            vertical8.Children.Add(Eweight);
            
            layoutALL.Children.Add(layout3);
            layoutALL.Children.Add(layout1);
            layoutALL.Children.Add(vertical1);
            layoutALL.Children.Add(vertical2);
            layoutALL.Children.Add(vertical3);
            layoutALL.Children.Add(vertical4);
            layoutALL.Children.Add(vertical5);
            layoutALL.Children.Add(vertical6);
            layoutALL.Children.Add(vertical7);
            layoutALL.Children.Add(vertical8);

            //layoutALL.Children.Add(savebtn);
            //layoutALL.Children.Add(updatebtn);
            layoutALL.Children.Add(testbtn);

            scroll.Content = layoutALL;
            Content = scroll;  

            testbtn.Clicked += testbtn_Clicked;
        }

        public async void savebtn_Clicked(object sender, EventArgs args)
        {
            //if personaldetail & Bodycomposition list count >1 (true)
            //then update
            //else insert

            //to calculate bfp
            if (EGender.Text.Equals("M"))
            {
                //calculate bfp male
                //1 kg = 2.204lbs
                //1cm = 0.39 inch
                //80kg, 75cm * 0.39
                f1 = ((Convert.ToSingle(Eweight.Text) * 2.204f )* 1.082f) + 94.42f;
                f2 = Convert.ToSingle(EWaist.Text) * 4.15f;
                leanbodymass = f1 - f2;
                bodyfatweight = Convert.ToSingle(Eweight.Text)*2.204f - leanbodymass;
                //a = bodyfatweight - leanbodymass;
                bfp = (bodyfatweight * 100) / (Convert.ToSingle(Eweight.Text) * 2.204f);
            }
            else if (EGender.Text.Equals("F"))
            {
                //calculate bfp female
                f1 = ((Convert.ToSingle(Eweight.Text) * 2.204f) * 0.732f) + 8.987f;
                f2 = Convert.ToSingle(EWaist.Text) / 3.140f;
                f3 = Convert.ToSingle(EHip.Text) * 0.434f;
                f4 = Convert.ToSingle(Eforearm.Text) * 0.434f;
                leanbodymass = f1 + f2 - f3 + f5;
                bodyfatweight = (Convert.ToSingle(Eweight.Text) * 2.204f) - leanbodymass;
                bfp = (bodyfatweight * 100) / (Convert.ToSingle(Eweight.Text) * 2.204f);
            }

            //Validation 
            if(EHip.Text.Equals("") || EWaist.Text.Equals("") || Eforearm.Text.Equals("")
                || Eweight.Text.Equals("") || Eheight.Text.Equals("") || Eage.Text.Equals("") || EGender.Text.Equals(""))
            {
                await DisplayAlert("Alert","Entry is not completed","Close");
            }
            else if (!EGender.Text.Equals("M") && !EGender.Text.Equals("F"))
            {
                await DisplayAlert("Alert", "Please enter gender\n'M' = Male\n'F' = Female", "Close");
            }
            else
            {
                //start putting data into list after validation
                pdm = new PersonalDetail
                {
                    age = Convert.ToInt32(Eage.Text),
                    gender = EGender.Text,
                    RegistrationFK_ID = StaticClass.RegistrationID
                };

                //calculate bmi
                bmi = Convert.ToSingle(Eweight.Text) / ((Convert.ToSingle(Eheight.Text) / 100) * (Convert.ToSingle(Eheight.Text) / 100));

                bcm = new BodyComposition
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
                    {
                        await DisplayAlert("Alert", "Failed to save", "Close");
                    }
                        //StaticClass.PersonalDetailID = await.pdvm.GetPersonalDetailID(StaticClass.RegistrationID);

                }
                catch (Exception e)
                {
                    throw;
                }
            }

            StaticClass.BodyCompositionID = await bcvm.GetBodyCompositionID(StaticClass.RegistrationID);
            StaticClass.PersonalDetailID = await pdvm.GetPersonalDetailID(StaticClass.RegistrationID);
            await Navigation.PushModalAsync(new MasterDetailHome());
        }

        public async void updatebtn_Clicked(object sender, EventArgs args) 
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
                || Eweight.Text.Equals("") || Eheight.Text.Equals("") || Eage.Text.Equals("") || EGender.Text.Equals(""))
            {
                await DisplayAlert("Alert","Entry is not completed","Close");
            }
            else if (!EGender.Text.Equals("M") && !EGender.Text.Equals("F"))
            {
                await DisplayAlert("Alert", "Please enter gender\n'M' = Male\n'F' = Female", "Close");
            }
            else
            {
                //start putting data into list after validation
                pdm = new PersonalDetail
                {
                    PersonalDetail_ID = StaticClass.PersonalDetailID,
                    age = Convert.ToInt32(Eage.Text),
                    gender = EGender.Text,
                    RegistrationFK_ID = StaticClass.RegistrationID
                };

                //calculate bmi
                bmi = Convert.ToSingle(Eweight.Text) / ((Convert.ToSingle(Eheight.Text)/100) * (Convert.ToSingle(Eheight.Text)/100));

                bcm = new BodyComposition
                {
                    BodyComposition_ID= StaticClass.BodyCompositionID,
                    hip = Convert.ToSingle(EHip.Text),
                    waist = Convert.ToSingle(EWaist.Text),
                    forearm = Convert.ToSingle(Eforearm.Text),
                    weight = Convert.ToSingle(Eweight.Text),
                    height = Convert.ToSingle(Eheight.Text),
                    bmi = bmi,
                    bfp = bfp,
                    RegistrationFK_ID = StaticClass.RegistrationID
                };

                pdvm.UpdateProfileList(pdm);
                bcvm.UpdateBodyComposition(bcm);
                await DisplayAlert("Success", "Profile Updated", "Close");
                await Navigation.PushModalAsync(new MasterDetailHome());
            }
        }

        public async void getPersonalDetail()
        {
            pdm = await pdvm.GetMyProfileList(StaticClass.RegistrationID);
            bcm = await bcvm.GetMyCompositionList(StaticClass.RegistrationID);
            EGender.BindingContext = pdm;
            EGender.SetBinding(Entry.TextProperty, "gender");

            Eage.BindingContext = pdm;
            Eage.SetBinding(Entry.TextProperty, "age");

            EHip.BindingContext = bcm;
            EHip.SetBinding(Entry.TextProperty, "hip");
            EWaist.BindingContext = bcm;
            EWaist.SetBinding(Entry.TextProperty, "waist");
            //EWaist2.BindingContext = bcm;
            //EWaist2.SetBinding(Entry.TextProperty, "waist2");
            Eforearm.BindingContext = bcm;
            Eforearm.SetBinding(Entry.TextProperty, "forearm");
            Eheight.BindingContext = bcm;
            Eheight.SetBinding(Entry.TextProperty, "height");
            Eweight.BindingContext = bcm;
            Eweight.SetBinding(Entry.TextProperty, "weight");
        }

        public async void testbtn_Clicked(object sender, EventArgs args)
        {
            try
            {
                int x;
                x = await bcvm.ValidateButton(StaticClass.RegistrationID);
                if (x > 0)
                {
                    //Update
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
                    if (EHip.Text.Equals("") || EWaist.Text.Equals("") || Eforearm.Text.Equals("")
                        || Eweight.Text.Equals("") || Eheight.Text.Equals("") || Eage.Text.Equals("") || EGender.Text.Equals(""))
                    {
                        await DisplayAlert("Alert", "Entry is not completed", "Close");
                    }
                    else if (!EGender.Text.Equals("M") && !EGender.Text.Equals("F"))
                    {
                        await DisplayAlert("Alert", "Please enter gender\n'M' = Male\n'F' = Female", "Close");
                    }
                    else
                    {
                        //start putting data into list after validation
                        pdm = new PersonalDetail
                        {
                            PersonalDetail_ID = StaticClass.PersonalDetailID,
                            age = Convert.ToInt32(Eage.Text),
                            gender = EGender.Text,
                            RegistrationFK_ID = StaticClass.RegistrationID
                        };

                        //calculate bmi
                        bmi = Convert.ToSingle(Eweight.Text) / ((Convert.ToSingle(Eheight.Text) / 100) * (Convert.ToSingle(Eheight.Text) / 100));

                        bcm = new BodyComposition
                        {
                            BodyComposition_ID = StaticClass.BodyCompositionID,
                            hip = Convert.ToSingle(EHip.Text),
                            waist = Convert.ToSingle(EWaist.Text),
                            forearm = Convert.ToSingle(Eforearm.Text),
                            weight = Convert.ToSingle(Eweight.Text),
                            height = Convert.ToSingle(Eheight.Text),
                            bmi = bmi,
                            bfp = bfp,
                            RegistrationFK_ID = StaticClass.RegistrationID
                        };

                        pdvm.UpdateProfileList(pdm);
                        bcvm.UpdateBodyComposition(bcm);
                        await DisplayAlert("Success", "Profile Updated", "Close");
                        await Navigation.PushModalAsync(new MasterDetailHome());
                    }
                }
                else 
                {
                   //Insert

                    //to calculate bfp
                    if (EGender.Text.Equals("M"))
                    {
                        //calculate bfp male
                        //1 kg = 2.204lbs
                        //1cm = 0.39 inch
                        //80kg, 75cm * 0.39
                        f1 = ((Convert.ToSingle(Eweight.Text) * 2.204f) * 1.082f) + 94.42f;
                        f2 = Convert.ToSingle(EWaist.Text) * 4.15f;
                        leanbodymass = f1 - f2;
                        bodyfatweight = Convert.ToSingle(Eweight.Text) * 2.204f - leanbodymass;
                        //a = bodyfatweight - leanbodymass;
                        bfp = (bodyfatweight * 100) / (Convert.ToSingle(Eweight.Text) * 2.204f);
                    }
                    else if (EGender.Text.Equals("F"))
                    {
                        //calculate bfp female
                        f1 = ((Convert.ToSingle(Eweight.Text) * 2.204f) * 0.732f) + 8.987f;
                        f2 = Convert.ToSingle(EWaist.Text) / 3.140f;
                        f3 = Convert.ToSingle(EHip.Text) * 0.434f;
                        f4 = Convert.ToSingle(Eforearm.Text) * 0.434f;
                        leanbodymass = f1 + f2 - f3 + f5;
                        bodyfatweight = (Convert.ToSingle(Eweight.Text) * 2.204f) - leanbodymass;
                        bfp = (bodyfatweight * 100) / (Convert.ToSingle(Eweight.Text) * 2.204f);
                    }

                    //Validation 
                    if (EHip.Text.Equals("") || EWaist.Text.Equals("") || Eforearm.Text.Equals("")
                        || Eweight.Text.Equals("") || Eheight.Text.Equals("") || Eage.Text.Equals("") || EGender.Text.Equals(""))
                    {
                        await DisplayAlert("Alert", "Entry is not completed", "Close");
                    }
                    else if (!EGender.Text.Equals("M") && !EGender.Text.Equals("F"))
                    {
                        await DisplayAlert("Alert", "Please enter gender\n'M' = Male\n'F' = Female", "Close");
                    }
                    else
                    {
                        //start putting data into list after validation
                        pdm = new PersonalDetail
                        {
                            age = Convert.ToInt32(Eage.Text),
                            gender = EGender.Text,
                            RegistrationFK_ID = StaticClass.RegistrationID
                        };

                        //calculate bmi
                        bmi = Convert.ToSingle(Eweight.Text) / ((Convert.ToSingle(Eheight.Text) / 100) * (Convert.ToSingle(Eheight.Text) / 100));

                        bcm = new BodyComposition
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
                            bool a;
                            a = await pdvm.AddPersonalDetail(pdm, bcm);
                            if (a == true)
                            {
                                await DisplayAlert("Personal Detail", "Detail Saved", "Close");

                            }
                            else
                            {
                                await DisplayAlert("Alert", "Failed to save", "Close");
                            }
                            //StaticClass.PersonalDetailID = await.pdvm.GetPersonalDetailID(StaticClass.RegistrationID);

                        }
                        catch (Exception e)
                        {
                            throw;
                        }
                    }

                    StaticClass.BodyCompositionID = await bcvm.GetBodyCompositionID(StaticClass.RegistrationID);
                    StaticClass.PersonalDetailID = await pdvm.GetPersonalDetailID(StaticClass.RegistrationID);
                    await Navigation.PushModalAsync(new MasterDetailHome());
                    
                }
            }
            catch (Exception e)
            {
                throw;
            }
        
        }
    }
}
