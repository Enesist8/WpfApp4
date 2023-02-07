using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void vigrish()
        {
            knopka1.IsEnabled = false;
            knopka2.IsEnabled = false;
            knopka3.IsEnabled = false;
            knopka4.IsEnabled = false;
            knopka5.IsEnabled = false;
            knopka6.IsEnabled = false;
            knopka7.IsEnabled = false;
            knopka8.IsEnabled = false;
            knopka9.IsEnabled = false;
            MessageBox.Show("YOU WIN!");
        }
        public void proighish()
        {
            knopka1.IsEnabled = false;
            knopka2.IsEnabled = false;
            knopka3.IsEnabled = false;
            knopka4.IsEnabled = false;
            knopka5.IsEnabled = false;
            knopka6.IsEnabled = false;
            knopka7.IsEnabled = false;
            knopka8.IsEnabled = false;
            knopka9.IsEnabled = false;
            MessageBox.Show("YOU LOSE!");
        }
        public void knopka1_Click(object sender, RoutedEventArgs e)
        {
            knopka1.Content = "X";
            knopka1.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka2_Click(object sender, RoutedEventArgs e)
        {
            knopka2.Content = "X";
            knopka2.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka3_Click(object sender, RoutedEventArgs e)
        {
            knopka3.Content = "X";
            knopka3.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka4_Click(object sender, RoutedEventArgs e)
        {
            knopka4.Content = "X";
            knopka4.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka5_Click(object sender, RoutedEventArgs e)
        {
            knopka5.Content = "X";
            knopka5.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka6_Click(object sender, RoutedEventArgs e)
        {
            knopka6.Content = "X";
            knopka6.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka7_Click(object sender, RoutedEventArgs e)
        {
            knopka7.Content = "X";
            knopka7.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka8_Click(object sender, RoutedEventArgs e)
        {
            knopka8.Content = "X";
            knopka8.IsEnabled = false;
            varianti_sobitiy();
            II();
        }
        public void knopka9_Click(object sender, RoutedEventArgs e)
        {
            knopka9.Content = "X";
            knopka9.IsEnabled = false;
            varianti_sobitiy();
            II();
        }

        private void Novaya(object sender, RoutedEventArgs e)
        {

            Button[] b = new Button[] { knopka1, knopka2, knopka3, knopka4, knopka5, knopka6, knopka7, knopka8, knopka9 };
            foreach (Button x in b)
            {
                x.IsEnabled = true;
            }
            new_game.Content = "RESTART";
            foreach (Button x in b)
            {
                x.Content = "";
            }
        }
        public void varianti_sobitiy()
        {
            if (knopka1.Content == "X" && knopka2.Content == "X" && knopka3.Content == "X")
            {
                vigrish();
            }
            else if (knopka1.Content == "X" && knopka4.Content == "X" && knopka7.Content == "X")
            {
                vigrish();
            }
            else if (knopka1.Content == "X" && knopka5.Content == "X" && knopka9.Content == "X")
            {
                vigrish();
            }
            else if (knopka2.Content == "X" && knopka5.Content == "X" && knopka8.Content == "X")
            {
                vigrish();
            }
            else if (knopka3.Content == "X" && knopka6.Content == "X" && knopka9.Content == "X")
            {
                vigrish();
            }
            else if (knopka3.Content == "X" && knopka5.Content == "X" && knopka7.Content == "X")
            {
                vigrish();
            }
            else if (knopka4.Content == "X" && knopka5.Content == "X" && knopka6.Content == "X")
            {
                vigrish();
            }
            else if (knopka6.Content == "X" && knopka7.Content == "X" && knopka8.Content == "X")
            {
                vigrish();


                if (knopka1.Content == "0" && knopka2.Content == "0" && knopka3.Content == "0")
                {
                    proighish();
                }
                else if (knopka1.Content == "0" && knopka4.Content == "0" && knopka7.Content == "0")
                {
                    proighish();
                }
                else if (knopka1.Content == "0  " && knopka5.Content == "0" && knopka9.Content == "0")
                {
                    proighish();
                }
                else if (knopka2.Content == "0  " && knopka5.Content == "0" && knopka8.Content == "0")
                {
                    proighish();
                }
                else if (knopka3.Content == "0" && knopka6.Content == "0" && knopka9.Content == "0")
                {
                    proighish();
                }
                else if (knopka3.Content == "0" && knopka5.Content == "0" && knopka7.Content == "0")
                {
                    proighish();
                }
                else if (knopka4.Content == "0  " && knopka5.Content == "0" && knopka6.Content == "0")
                {
                    proighish();
                }
                else if (knopka6.Content == "0" && knopka7.Content == "0" && knopka8.Content == "0")
                {
                    proighish();
                }
            }

        }
        public void II()
        {
            Random rnd = new Random();
            int RANDOM = rnd.Next(1, 10);
            if (knopka1.IsEnabled == true || knopka2.IsEnabled == true || knopka3.IsEnabled == true || knopka4.IsEnabled == true || knopka5.IsEnabled == true || knopka6.IsEnabled == true || knopka7.IsEnabled == true || knopka8.IsEnabled == true || knopka9.IsEnabled == true)
            {
                if (RANDOM == 1)
                {
                    if (knopka1.IsEnabled == true)
                    {
                        knopka1.IsEnabled = false;
                        knopka1.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 2)
                {
                    if (knopka2.IsEnabled == true)
                    {
                        knopka2.IsEnabled = false;
                        knopka2.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 3)
                {
                    if (knopka3.IsEnabled == true)
                    {
                        knopka3.IsEnabled = false;
                        knopka3.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 4)
                {
                    if (knopka4.IsEnabled == true)
                    {
                        knopka4.IsEnabled = false;
                        knopka4.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 5)
                {
                    if (knopka5.IsEnabled == true)
                    {
                        knopka5.IsEnabled = false;
                        knopka5.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 6)
                {
                    if (knopka6.IsEnabled == true)
                    {
                        knopka6.IsEnabled = false;
                        knopka6.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 7)
                {
                    if (knopka7.IsEnabled == true)
                    {
                        knopka7.IsEnabled = false;
                        knopka7.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 8)
                {
                    if (knopka8.IsEnabled == true)
                    {
                        knopka8.IsEnabled = false;
                        knopka8.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }
                else if (RANDOM == 9)
                {
                    if (knopka9.IsEnabled == true)
                    {
                        knopka9.IsEnabled = false;
                        knopka9.Content = "O";
                    }
                    else
                    {
                        II();
                    }
                }

                else
                {
                    MessageBox.Show("Ничья!");
                }
                varianti_sobitiy();
            }
        }
        private void new_game_Click(object sender, RoutedEventArgs e)
        {
            if (new_game.IsEnabled == true)
            {
                knopka1.Content = " ";
                knopka2.Content = " ";
                knopka3.Content = " ";
                knopka4.Content = " ";
                knopka5.Content = " ";
                knopka6.Content = " ";
                knopka7.Content = " ";
                knopka8.Content = " ";
                knopka9.Content = " ";
                knopka1.IsEnabled = true;
                knopka2.IsEnabled = true;
                knopka3.IsEnabled = true;
                knopka4.IsEnabled = true;
                knopka5.IsEnabled = true;
                knopka6.IsEnabled = true;
                knopka7.IsEnabled = true;
                knopka8.IsEnabled = true;
                knopka9.IsEnabled = true;
            }
        }
    }
}
