using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class MasterDetailHome : MasterDetailPage
    {
        NavigationMenu navmenu;
        
        public MasterDetailHome()
        {
            navmenu = new NavigationMenu();
            navmenu.Menu.ItemSelected += (sender, e) => NavigationTo(e.SelectedItem as MenuList);

            Master = navmenu;
            Detail = new NavigationPage(new HomePage())
            {
                Style = StaticAppStyle.NavigationLabelStyle
            };     
         }

        void NavigationTo(MenuList menu)
        {
            if (menu == null)
                return;

            Page DisplayPage = (Page)Activator.CreateInstance(menu.PageType);
            Detail = new NavigationPage(DisplayPage) 
            {
                Style = StaticAppStyle.NavigationLabelStyle
            };

            navmenu.Menu.SelectedItem = null;
            IsPresented = false;
        }

        
    }
}
