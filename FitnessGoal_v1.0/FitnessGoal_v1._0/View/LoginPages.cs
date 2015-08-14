using System;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using FitnessGoal_v1;
using Xamarin.Forms;
using System.Collections.Generic;
using Microsoft.WindowsAzure.MobileServices.Sync;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FitnessGoal_v1._0
{
    public class LoginPages : ContentPage
    { 
        public static Registration login;
        LoginViewModel LVM = new LoginViewModel();
        BodyCompositionViewModel bdvm = new BodyCompositionViewModel();
        PersonalDetailViewModel pdvm = new PersonalDetailViewModel();

        Entry Eusername = new Entry()
        {
            Placeholder = "Username",
            TextColor = Color.Black,
            BackgroundColor = Color.White
        };

        Entry Epassword = new Entry()
        {
            Placeholder = "Password",
            BackgroundColor = Color.White,
            TextColor = Color.Black,
            IsPassword = true
        };
        public LoginPages()
        {
            Registration.Current = null;
            Registration.IsUser = false;

            StackLayout layoutALL = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center

            };

            StackLayout layout2 = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness (40,0,40,0)
            };

            StackLayout layout1 = new StackLayout() 
            {
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(40, 0, 40, 0)
            };

            Label title = new Label()
            {
                Style = StaticAppStyle.LabelStyle,
                Text = "FITNESS GOAL",
                TextColor = Color.White,
                FontSize = 30
            };
                        
            Button loginbtn = new Button() 
            {
                Style = StaticAppStyle.Button01,
                Text = "Sign In",
                //Command = new Command(() => Navigation.PushModalAsync(new MasterDetailHome()))

            };

            Button Registerbtn = new Button()
            {
                Style = StaticAppStyle.Button01,
                Text = "Register",
                Command = new Command(() => Navigation.PushModalAsync(new RegistrationPage()))
            };

            Button Forgotbtn = new Button()
            {
                Style = StaticAppStyle.Button01,
                BackgroundColor = Color.Transparent,
                Text = "Forgot Password",
                TextColor = Color.Red,
                Command = new Command(() => Navigation.PushModalAsync(new MasterDetailHome()))
            };

            Style = StaticAppStyle.PageColor;
            layout2.Children.Add(Eusername);
            layout2.Children.Add(Epassword);
            layout2.Children.Add(loginbtn);
            layout2.Children.Add(Registerbtn);
            layout2.Children.Add(Forgotbtn);

            layout1.Children.Add(title);

            layoutALL.Children.Add(layout1);
            layoutALL.Children.Add(layout2);

            Content = layoutALL;

            loginbtn.Clicked += Loginbtn_Clicked;
        }

        public async void Loginbtn_Clicked(object sender, EventArgs args)
        {
            login = new Registration
            {
                username = Eusername.Text,
                password = Epassword.Text
            };

            try
            {
                int x;
                x = await LVM.ValidateLogin(login);
                if (x > 0)
                {
                    
                    await Navigation.PushModalAsync(new MasterDetailHome());
                }

                else 
                {
                    await DisplayAlert("Alert", "Invalid username or password", "Close");
                }
                    
                StaticClass.RegistrationID = await LVM.GetuserID(Registration.Current);
                StaticClass.ExerciseProgramID = await LVM.GetProgramID(StaticClass.RegistrationID);
                StaticClass.BodyCompositionID = await bdvm.GetBodyCompositionID(StaticClass.RegistrationID);
                StaticClass.PersonalDetailID = await pdvm.GetPersonalDetailID(StaticClass.RegistrationID);
            }
            catch (Exception e) 
            {
                throw;
            };

        }
    }
}
