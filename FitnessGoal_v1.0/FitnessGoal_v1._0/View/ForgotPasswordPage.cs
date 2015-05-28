using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class ForgotPasswordPage : ContentPage
    {
        public ForgotPasswordPage()
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
                VerticalOptions = LayoutOptions.Center,
                Padding = new Thickness(40, 0, 40, 0)
            };

            Entry email = new Entry 
            {
                Placeholder = "Email Address",
                BackgroundColor = Color.White
            };

            Button Donebtn = new Button 
            { 
                Style = StaticAppStyle.Button01,
                Text = "Send",
                Command = new Command(() => Navigation.PushModalAsync(new LoginPages()))
            };

            Button BackBtn = new Button
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
                Text = "Insert your email address and check your email",
                TextColor = Color.Red,
                FontSize = 18,
                BackgroundColor = StaticAppStyle.MenuColour
            };

            layout1.Children.Add(title);

            layout2.Children.Add(layout1);
            layout2.Children.Add(subtitle);
            layout2.Children.Add(email);
            layout2.Children.Add(Donebtn);
            layout2.Children.Add(BackBtn);

            layoutALL.Children.Add(layout1);
            layoutALL.Children.Add(layout2);
            Content = layoutALL;

        }
    }
}
