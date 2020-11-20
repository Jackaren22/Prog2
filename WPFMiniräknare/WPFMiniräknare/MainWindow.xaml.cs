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

namespace WPFMiniräknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string calculation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
            number1 = 0;
            number2 = 0;
            calculation = "";
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += PlusButton.Content;
            calculation = "+";
        }
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += MinusButton.Content;
            calculation = "-";
        }
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += MultiplyButton.Content;
            calculation = "*";
        }
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += DivideButton.Content;
            calculation = "/";
        }
        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += DecimalButton.Content;
        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += EqualsButton.Content;
            switch(calculation)
            {
                case "+":
                    TextBox.Text += (number1 + number2).ToString();
                    number1 = 0;
                    number2 = 0;
                    calculation = "";
                    break;

                case "-":
                    TextBox.Text += (number1 - number2).ToString();
                    number1 = 0;
                    number2 = 0;
                    calculation = "";
                    break;

                case "*":
                    TextBox.Text += (number1 * number2).ToString();
                    number1 = 0;
                    number2 = 0;
                    calculation = "";
                    break;

                case "/":
                    TextBox.Text += (number1 / number2).ToString();
                    number1 = 0;
                    number2 = 0;
                    calculation = "";
                    break;

                case "":
                    TextBox.Text = "ERROR";
                    number1 = 0;
                    number2 = 0;
                    calculation = "";
                    break;
            }
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1*10) + 1;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                TextBox.Text += OneButton.Content;
            }

        }
        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 2;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                TextBox.Text += TwoButton.Content;
            }
        }
        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 3;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                TextBox.Text += ThreeButton.Content;
            }
        }
        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 4;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                TextBox.Text += FourButton.Content;
            }
        }
        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 5;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                TextBox.Text += FiveButton.Content;
            }
        }
        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 6;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                TextBox.Text += SixButton.Content;
            }
        }
        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 7;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                TextBox.Text += SevenButton.Content;
            }
        }
        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 8;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                TextBox.Text += EightButton.Content;
            }
        }
        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10) + 9;
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                TextBox.Text += NineButton.Content;
            }
        }
        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (calculation == "")
            {
                number1 = (number1 * 10);
                TextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                TextBox.Text += ZeroButton.Content;
            }
        }

    }
}
