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
            //lblNumbers.Content = string.Empty;
            //lblResult.Content = "0";

            if ("123456789".Contains(n))
            switch (n)
            {
                case '0':
                        lblResult.Content += "0";
                        break;
                case '1':
                        lblResult.Content += "1";
                        break;
                case '2':
                        lblResult.Content += "2";
                        break;
                case '3':
                        lblResult.Content += "3";
                        break;
                case '4': 
                        lblResult.Content += "4";
                        break;
                case '5': 
                        lblResult.Content += "5";
                        break;
                case '6': 
                        lblResult.Content += "6";
                        break;
                case '7': 
                        lblResult.Content += "7";
                        break;
                case '8': 
                        lblResult.Content += "8";
                        break;
                case '9': 
                        lblResult.Content += "9";
                        break;
            }

            if ("±%÷×ー+.".Contains(n))
            {
                lblResult.Content = n;
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

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lblNumbers.Content = string.Empty;
            lblResult.Content = "0";
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPercent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMultiple_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnFour_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
