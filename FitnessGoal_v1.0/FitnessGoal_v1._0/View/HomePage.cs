using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class HomePage : ContentPage
    {
        public HomePage()
        {
            Title = "Home Page";

            StackLayout layout1 = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.White
            };

            Label quote = new Label() 
            {
                Text = "Feel Sore Today or Feel Sorry Tomorrow",
                Style = StaticAppStyle.LabelStyle,
                TextColor = Color.White,
                FontAttributes = FontAttributes.Bold
                
            };

            layout1.Children.Add(quote);

            Content = layout1;

        }
    }
}
