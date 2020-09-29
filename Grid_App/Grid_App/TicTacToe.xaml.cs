using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
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
                for (int g = 0; g < 3; g++)
                {

                    grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                }
                for (int f = 0; f < 3; f++)
                {
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                }
                change = new Button
                {
                    Text = "Who's first?"
                };
                change.Clicked += Change_Clicked;
                res = new Button
                {
                    Text = "Reset game"
                };
                res.Clicked += Res_Clicked;

                for (int i = 0; i < 3; i++) //Генерация поля
                {
                    for (int j = 0; j < 3; j++)
                    {


                        stat = new Label
                        {
                            BackgroundColor=Color.Green,
                            FontSize = 30,
                            Text = "",
                            HorizontalTextAlignment = TextAlignment.Center,
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
                grid.Children.Add(res, 2,3);
                Content = grid;

            }
      
        private void Res_Clicked(object sender, EventArgs e)
        {
            Reset();
            chck = 0;//Перезапуск игры
        }
          
        List<Label> lst = new List<Label>() { }; //сохраняем здесь поля
        private void Tap_Tapped(object sender, EventArgs e)

            {

         
              Label stat = sender as Label;



            if (stat.Text == "") //Проверка на наличие текста в поле


                if (chck % 2 == 0)
                {
                    change.Text = "0";
                    stat.Text = "X";
                    chck++;
                    lst.Add(stat);
                
                }
                  else if (chck % 2 != 0)
                 {
                    change.Text = "X";
                    chck++;
                    stat.Text = "0";
                    lst.Add(stat);
                 }

                if (checkDraw() == true)
                {
                    DisplayAlert("Игра окончена", "Ничья", "Новая игра");
                    Reset();
                    chck = 0;
                }



           }
        bool checkDraw() //Проверка на ничью
        {
            if(chck==9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
/*        bool checkWinner()
        {

        }*/

        Random strt = new Random();
        int chck = 0;
        private void Change_Clicked(object sender, EventArgs e) //Рандомайзер, кто будет ходить первый
        {
            chck = strt.Next(0, 2);

    
        }


        }
    }

