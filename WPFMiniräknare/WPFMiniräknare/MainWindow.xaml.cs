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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += PlusButton.Content;
        }
        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += MinusButton.Content;
        }
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += MultiplyButton.Content;
        }
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += DivideButton.Content;
        }
        private void DecimalButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += DecimalButton.Content;
        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "Yeah uh idk";
        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += OneButton.Content;
        }
        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += TwoButton.Content;
        }
        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ThreeButton.Content;
        }
        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += FourButton.Content;
        }
        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += FiveButton.Content;
        }
        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += SixButton.Content;
        }
        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += SevenButton.Content;
        }
        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += EightButton.Content;
        }
        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += NineButton.Content;
        }
        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ZeroButton.Content;
        }

    }
}
