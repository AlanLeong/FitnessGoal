using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class SetRepWeight
    {
        int set = 4;
        int rep = 10;
        double RM;
        int weightlifted;
        double startingweight;

        public void calc() 
        {
            //must perform 10 reps
            RM = weightlifted/0.75;
            startingweight = RM * 0.6;
        }
    }
}
