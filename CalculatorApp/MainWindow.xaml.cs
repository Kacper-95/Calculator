using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculatorApp
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
        // numbers
        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + one.Content.ToString();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + two.Content.ToString();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + three.Content.ToString();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + four.Content.ToString();
        }

        private void Fife_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + fife.Content.ToString();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + six.Content.ToString();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + seven.Content.ToString();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + eight.Content.ToString();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + nine.Content.ToString();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text.ToString() == "0")
                TB.Text = "";
            TB.Text = TB.Text + zero.Content.ToString();
        }
        
        // actions

        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text != "")
            {
                label.Content = TB.Text.ToString() + "*";
                TB.Text = "";
            }
            else
            {
                label.Content = label.Content + "*";
            }
            dot.IsEnabled = true;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text != "")
            {
                label.Content = TB.Text.ToString() + "+";
                TB.Text = "";
            }
            else
            {
                label.Content = label.Content + "+";
            }
                dot.IsEnabled = true;
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text != "")
            {
                label.Content = TB.Text.ToString() + "-";
                TB.Text = "";
            }
            else
            {
                label.Content = label.Content + "-";
            }

            dot.IsEnabled = true;
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            if (TB.Text != "")
            {
                label.Content = TB.Text.ToString() + "/";
                TB.Text = "";
            }
            else
            {
                label.Content = label.Content + "/";
            }
            dot.IsEnabled = true;
        }

        private void Exp_Click(object sender, RoutedEventArgs e)
        {
            
                if (TB.Text != "")
                {
                    label.Content = TB.Text + "^";
                    TB.Text = "";
                }
                else
                {
                    label.Content = label.Content + "^";
                }

                dot.IsEnabled = true;
                    
        }

        private void Sqrt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text != "" || TB.Text != "0")
                {
                    label.Content = Math.Sqrt(Convert.ToDouble(TB.Text));
                    TB.Text = "";
                }

                else
                {
                    label.Content = "!Error!";
                }

            }
            catch (Exception ex)
            {
                if (TB.Text == "")
                {
                    label.Content = Math.Sqrt(Convert.ToDouble(label.Content));

                }
            }
            
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            result();
            try
            {
                
                if (label.Content.ToString() == "" || label.Content.ToString() == "0" || label.Content.ToString() == "!Error!")
                {
                    label.Content = TB.Text;
                    TB.Text = "";
                }
            }
            catch (Exception ex) 
            { }
        }

        private void result()
        {
            try
            {
                string lab = label.Content.ToString();
                string ff = lab.Remove(lab.Length - 1, 1);
                double first = Convert.ToDouble(ff);
                double second = Convert.ToDouble(TB.Text);
                double res;

                if (lab.Contains("+"))
                {
                    res = first + second;
                    label.Content = res.ToString();
                }
                if (lab.Contains("-"))
                {
                    res = first - second;
                    label.Content = res.ToString();
                }
                if (lab.Contains("*"))
                {
                    res = first * second;
                    label.Content = res.ToString();
                }
                if (lab.Contains("/"))
                {
                    res = first / second;
                    label.Content = res.ToString();
                }
                if (lab.Contains("^"))
                {
                    res = Math.Pow(first,second);
                    label.Content = res.ToString();
                }
                
                TB.Text = "";
            }
            catch (Exception exc)
            {
                
            }

        }
        
        // special 
        private void R_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string txt = TB.Text.ToString().Remove(TB.Text.ToString().Length - 1, 1);
                TB.Text = txt;
            }
            catch (Exception ex)
            {
            }
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            TB.Text = TB.Text + dot.Content.ToString();
            if (TB.Text.Contains(","))
                dot.IsEnabled = false;
        }

      
        
    }
}
