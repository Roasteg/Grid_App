using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/*namespace Grid_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent;
            BoxView box;
           /* Grid grid = new Grid
            {
               RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}
                },
               ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1, GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1, GridUnitType.Star)}
                },

            };*/
           /*Grid grid = new Grid();
            for (int g = 0; g < 3; g++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }*/
/*            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    box = new BoxView { Color = Color.FromRgb(200, 20, 20) };
                    grid.Children.Add(box,i,j);
                    var tap = new TapGestureRecognizer();
                    tap.Tapped += Tap_Tapped;
                    box.GestureRecognizers.Add(tap);
                }
            }
            Content = grid;
        }

        Random rnd = new Random();
        List<BoxView> lst = new List<BoxView>() { };
        private void Tap_Tapped(object sender, EventArgs e)
        {
            BoxView box = sender as BoxView;
            // box.Color = Color.FromRgb(rnd.Next(0, 255), rnd.Next(0,255), rnd.Next(0,255));
            if (lst.Contains(box))
            {
                box.Color = Color.FromRgb(200, 20, 20);
                lst.Remove(box);
            }
            else
            {
                box.Color = Color.FromRgb(0, 200, 50);
                lst.Add(box);
            }
          
        }
    }
}
*/