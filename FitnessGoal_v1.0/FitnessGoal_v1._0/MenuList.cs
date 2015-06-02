using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    public class MenuList
    {
        public string title { get; set; }
        public string icon { get; set; }
        public Type PageType { get; set; }
    }

    public class MenuCell : ImageCell 
    {
        public MenuCell()
            : base()
        {
            this.TextColor = Color.White;
        }
    }
    public class MenuListView : ListView
    {
        public MenuListView()
        {

            List<MenuList> menulist = new List<MenuList>();
            menulist.Add(new MenuList()
            {
                title = "My Profile",
                icon = "User.png",
                PageType = typeof(MyProfilePage)

            });
            
            menulist.Add(new MenuList()
            {
                title = "Personal Detail",     
                icon = "User.png",
                PageType = typeof(PersonalDetailPage)

             });

            menulist.Add(new MenuList()
            {
                title = "My Exercise ",
                icon = "ExerciseProgram.png",
                PageType = typeof(ExerciseProgramPage)

            });

            menulist.Add(new MenuList()
            {
                title = "Progress Report",
                icon = "ProgressDetail.png",
                PageType = typeof(ProgressReportPage)

            });

            menulist.Add(new MenuList()
            {
                title = "Set Notification",
                icon = "Notification.png",
                PageType = typeof(PersonalDetailPage)

            });

            menulist.Add(new MenuList()
            {
                title = "Tutorial Video",
                icon = "Search.png",
                PageType = typeof(VideoPage)

            });

            menulist.Add(new MenuList()
            {
                title = "Map",
                icon = "Search.png",
                PageType = typeof(VideoPage)

            });

            //List , Image got item source, not all also got itemsource
            ItemsSource = menulist;
            VerticalOptions = LayoutOptions.FillAndExpand;
            BackgroundColor = Color.Transparent;

            var cell = new DataTemplate(typeof(MenuCell));
            //set binding = bind to create list cell to form list view
            cell.SetBinding(MenuCell.TextProperty, "title");
            cell.SetBinding(MenuCell.ImageSourceProperty, "icon");

            ItemTemplate = cell;
        }
    }
}
