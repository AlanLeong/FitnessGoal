using System;
using Xamarin.Forms;

namespace FitnessGoal_v1._0
{
    class StaticAppStyle
    {
        //THEME 
        public static Color ThemeColor = Color.FromHex("#1e90ff");
        public static Color MenuColour = Color.FromHex("#0066cc");
        //public static Color MenuCellColour = Color.White;
        public static Color MenuWordColour = Color.Black;

        //FONT SIZE
        public static int Titlesize = 20;
        public static int MenuWordSize = 12;

        //BUTTON
        public static Style Button01
        {
            get
            { 
                return new Style(typeof(Button))
                {
                    Setters =
                    {
                        new Setter {Property = Button.VerticalOptionsProperty, Value = LayoutOptions.EndAndExpand},
                        new Setter {Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.EndAndExpand},
                        new Setter {Property = Button.TextColorProperty, Value = Color.White},
                        new Setter {Property = Button.BackgroundColorProperty, Value = MenuColour}

                    }
                };
            }
        }

        //Page
        public static Style PageColor
        {
            get 
            {
                return new Style(typeof(Page))
                {
                    Setters = 
                    {
                        //new Setter {Property = Page.BackgroundColorProperty, Value = Color.White}
                    }
                };
            }
        }

        //Label
        public static Style LabelStyle
        {
            get
            {
                return new Style(typeof(Label))
                {
                    Setters = 
                    {
                        new Setter {Property = Label.BackgroundColorProperty, Value = MenuColour},
                        new Setter {Property = Label.FontSizeProperty, Value = Titlesize},
                        new Setter {Property = Label.VerticalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                        new Setter {Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                        //new Setter {Property = Label.XAlignProperty, Value = LayoutOptions.FillAndExpand},
                        //new Setter {Property = Label.YAlignProperty, Value = LayoutOptions.FillAndExpand},
                        new Setter {Property = Label.TextColorProperty, Value = Color.Black},
                        new Setter {Property = Label.HeightRequestProperty, Value = 100},
                        new Setter {Property = Label.TextProperty, Value = 30},
                        new Setter {Property = Label.XAlignProperty, Value = TextAlignment.Center},
                        new Setter {Property = Label.YAlignProperty, Value = TextAlignment.Center}
                    }
                };
            }
        }

        public static Style LabelStyle2
        {
            get
            {
                return new Style(typeof(Label))
                {
                    Setters = 
                    {
                        new Setter {Property = Label.BackgroundColorProperty, Value = Color.Gray},
                        new Setter {Property = Label.FontSizeProperty, Value = 18},
                        new Setter {Property = Label.VerticalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                        new Setter {Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                        //new Setter {Property = Label.XAlignProperty, Value = LayoutOptions.FillAndExpand},
                        //new Setter {Property = Label.YAlignProperty, Value = LayoutOptions.FillAndExpand},
                        new Setter {Property = Label.TextColorProperty, Value = Color.White},
                        new Setter {Property = Label.HeightRequestProperty, Value = 50},
                        new Setter {Property = Label.TextProperty, Value = 18},
                        new Setter {Property = Label.XAlignProperty, Value = TextAlignment.Center},
                        new Setter {Property = Label.YAlignProperty, Value = TextAlignment.Center},
                        new Setter {Property = Label.WidthRequestProperty, Value = 5}
                    }
                };
            }
        }

        public static Style EntryStyle
        {
            get
            {
                return new Style(typeof(Entry))
                {
                    Setters = 
                    {
                        new Setter {Property = Entry.BackgroundColorProperty, Value = Color.White},
                        new Setter {Property = Entry.VerticalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                        new Setter {Property = Entry.HorizontalOptionsProperty, Value = LayoutOptions.FillAndExpand},
                        new Setter {Property = Entry.TextColorProperty, Value = Color.Black},
                        new Setter {Property = Entry.HeightRequestProperty, Value = 50},
                        new Setter {Property = Entry.TextProperty, Value = 10},
                        //new Setter {Property = Entry.XAlignProperty, Value = TextAlignment.Center},
                       // new Setter {Property = Entry.YAlignProperty, Value = TextAlignment.Center},
                        new Setter {Property = Entry.WidthRequestProperty, Value = 10}
                    }
                };
            }
        }

        public static Style NavigationLabelStyle 
        {
            get 
            {
                return new Style(typeof(NavigationPage))
                {
                    Setters = 
                    {
                        new Setter {Property = NavigationPage.BarTextColorProperty, Value = Color.White},
                        new Setter {Property = NavigationPage.BarBackgroundColorProperty, Value = StaticAppStyle.ThemeColor}
                    }
                };
            }
        }
                
    }
}
