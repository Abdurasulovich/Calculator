using System;
using System.Runtime.Serialization;
using System.Windows;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void WriteAction(char n)
        {
            if (lblResult.Content.ToString()!.Length != 15)
            {
                if (lblResult.Content.ToString() == "0" && n == '0')
                    return;
                else if ("1234567890.".Contains(n))
                {
                    if (n == '.') ;
                    else if (lblResult.Content.ToString() == "0" || lblNumbers.Content.ToString()!.Length>3)
                        lblResult.Content = "";
                    lblResult.Content += n.ToString();
                    return;
                }
            }

            if ("+-÷×".Contains(n))
            {
                if (!lblNumbers.Content.ToString()!.Contains(n.ToString()) && lblNumbers.Content.ToString() != "")
                    lblNumbers.Content = lblNumbers.Content.ToString()!.Replace(lblNumbers.Content.ToString()![lblNumbers.Content.ToString()!.Length - 1], n);
                else if(lblNumbers.Content.ToString()=="")
                {
                    lblNumbers.Content = lblResult.Content + n.ToString();
                    lblResult.Content = "0";
                }
            }
        }


        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (lblNumbers.Content.ToString() != "")
            {
                var hold = lblNumbers.Content.ToString() + lblResult.Content.ToString()! + "=";

                switch (lblNumbers.Content.ToString()![lblNumbers.Content.ToString()!.Length - 1])
                {
                    case '+':
                        lblResult.Content = (double.Parse(lblNumbers.Content.ToString()!.Remove(lblNumbers.Content.ToString()!.Length - 1, 1)) + double.Parse(lblResult.Content.ToString()!)).ToString();
                        break;
                    case '-':
                        lblResult.Content = (double.Parse(lblNumbers.Content.ToString()!.Remove(lblNumbers.Content.ToString()!.Length - 1, 1)) - double.Parse(lblResult.Content.ToString()!)).ToString();
                        break;
                    case '×':
                        lblResult.Content = (double.Parse(lblNumbers.Content.ToString()!.Remove(lblNumbers.Content.ToString()!.Length - 1, 1)) * double.Parse(lblResult.Content.ToString()!)).ToString();
                        break;
                    case '÷':
                        lblResult.Content = (double.Parse(lblNumbers.Content.ToString()!.Remove(lblNumbers.Content.ToString()!.Length - 1, 1)) / double.Parse(lblResult.Content.ToString()!)).ToString();
                        break;
                }
                lblNumbers.Content = hold;
                btnEqual.IsEnabled = false;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblNumbers.Content = string.Empty;
            lblResult.Content = "0";
            btnEqual.IsEnabled = true;

        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            if (lblResult.Content.ToString() is not null && lblResult.Content.ToString() != "0")
            {
                lblResult.Content = lblResult.Content.ToString()!.Remove(lblResult.Content.ToString()!.Length - 1);
            }
                 
        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('÷');

        }

        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('×');
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('-');

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('+');

        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('1');
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('2');
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('3');
        }
        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('4');
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('5');
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('6');
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('7');
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('8');
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('9');
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            WriteAction('0');
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if(!lblResult.Content.ToString()!.Contains('.'))
                WriteAction('.');
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            if (lblResult.Content.ToString()!.Contains("-"))
                lblResult.Content = lblResult.Content.ToString()!.Remove(startIndex: 0, count: 1);
            else lblResult.Content = "-" + lblResult.Content;
        }

        private void brDragable_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
