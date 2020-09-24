using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;

namespace Grid_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TicTacToe : ContentPage
    {
        public TicTacToe()
        {
            Reset();
        }
            //InitializeComponent();
            BoxView tic;
            Label stat;
            Button change, res;

            void Reset()
            {
                Grid grid = new Grid();
                for (int g = 0; g < 4; g++)
                {

                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                }
                for (int f = 0; f < 3; f++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                }
                change = new Button
                {
                    Text = "Change x/0"
                };
                change.Clicked += Change_Clicked;
                res = new Button
                {
                    Text = "Reset game"
                };
                res.Clicked += Res_Clicked;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {


                        stat = new Label
                        {
                            BackgroundColor=Color.Green,
                            FontSize = 30,
                            Text = "",
                            TextColor=Color.Black,
                            VerticalTextAlignment = TextAlignment.Center,


                        };
                        var tap = new TapGestureRecognizer();
                        tap.Tapped += Tap_Tapped;
                        grid.Children.Add(stat, i, j);
                        stat.GestureRecognizers.Add(tap);


                    }

                }

                grid.Children.Add(change, 0, 3);
                grid.Children.Add(res, 3, 3);
                Content = grid;

            }

        private void Res_Clicked(object sender, EventArgs e)
        {
            Reset();
        }
          
        List<Label> lst = new List<Label>() { };
        private void Tap_Tapped(object sender, EventArgs e)

            {

            check();
              Label stat = sender as Label;

            if (chck % 2 == 0)
            {

              stat.Text = "X";
              chck++;
              lst.Add(stat);
             }
              else if (chck % 2 != 0)
             {
              chck++;
              stat.Text = "0";
              lst.Add(stat);
             }
            else if(stp==true)
            {
                DisplayAlert("Alert", "Yes", "ok");
            }

           }
        string l = "X";
        string h = "0";
        bool stp;
        void check()
        {
            foreach(Label stat in lst)
            {
                if (lst.Contains(stat))
                {
                    stp = true;
                }
                else
                {
                    stp = false;
                }
                    
            }
        }
        Random strt = new Random();


            int chck = 0;
            private void Change_Clicked(object sender, EventArgs e)
            {
            chck = strt.Next(0, 2);
            }
        }
    }

