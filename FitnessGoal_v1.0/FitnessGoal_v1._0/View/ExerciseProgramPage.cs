﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class ExerciseProgramPage : ContentPage
    {
        public ExerciseProgramPage()
        {
            Title = "Exercise Program";

            Content = new StackLayout
            {
                Children = {
					new Label { Text = "Hello ContentPage" }
				}
            };
        }
    }
}