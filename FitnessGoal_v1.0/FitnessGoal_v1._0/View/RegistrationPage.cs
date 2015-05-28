using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class RegistrationPage : ContentPage
    {
        public static Registration register;
        LoginViewModel LVM = new LoginViewModel();

        Entry Eusername = new Entry
        {
            Placeholder = "Username",
            BackgroundColor = Color.White,
            TextColor = Color.Black
        };

        Entry Epassword = new Entry
        {
            Placeholder = "Password",
            BackgroundColor = Color.White,
            TextColor = Color.Black
        };

        Entry Eemail = new Entry
        {
            Placeholder = "Email",
            BackgroundColor = Color.White,
            TextColor = Color.Black
        };

        public RegistrationPage()
        {

            StackLayout layout1 = new StackLayout 
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(40, 0, 40, 0)
            };

            StackLayout layout2 = new StackLayout 
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(40, 0, 40, 0)
            };

            StackLayout layoutALL = new StackLayout 
            {
                VerticalOptions = LayoutOptions.Center
            };

            Button registerbtn = new Button 
            { 
                Style = StaticAppStyle.Button01,
                Text = "Create Account",
                //code to navigate back to sign in page
                //Command = new Command(() => Navigation.PushModalAsync(new LoginPages()))
            };

            Button Backbtn = new Button 
            {
                Style = StaticAppStyle.Button01,
                Text = "Back to Sign in",
                Command = new Command(() => Navigation.PushModalAsync(new LoginPages()))
            };

            Label title = new Label
            {
                Style = StaticAppStyle.LabelStyle,
                Text = "FITNESS GOAL",
                TextColor = Color.White,
                FontSize = 30
            };

            Label subtitle = new Label
            {
                Text = "Registration",
                FontSize = 18,
                TextColor = Color.White,
                BackgroundColor = StaticAppStyle.MenuColour,
                XAlign = TextAlignment.Center
            };

            layout1.Children.Add(title);

            layout2.Children.Add(subtitle);
            layout2.Children.Add(Eusername);
            layout2.Children.Add(Epassword);
            layout2.Children.Add(Eemail);
            layout2.Children.Add(registerbtn);
            layout2.Children.Add(Backbtn);

            layoutALL.Children.Add(layout1);
            layoutALL.Children.Add(layout2);

            Content = layoutALL;

            registerbtn.Clicked += btnRegister_Clicked;
        }

        public async void btnRegister_Clicked(object sender, EventArgs args) 
        {
            register = new Registration
            {
                username = Eusername.Text,
                password = Epassword.Text,
                email = Eemail.Text
            };

            if (Eusername.Text.Equals("") ||  Epassword.Text.Equals("") || Eemail.Text.Equals(""))
            {
                await DisplayAlert("Alert", "Entry is empty", "Close");
            }
            else
            {
                try
                {
                    int x;
                    x = await LVM.Adduser(register);
                    if (x == 0)
                    {
                        await DisplayAlert("Registration", "Registration success", "Close");
                        await Navigation.PushModalAsync(new LoginPages());
                    }
                    else
                        await DisplayAlert("Alert", "Username Existed", "Close");
                }
                catch (Exception e)
                {
                    throw;
                }
            }
        }
    }
}
