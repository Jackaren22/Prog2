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

namespace Slutprojekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        int qNum = 0;

        int i;

        int score;

        public MainWindow()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1") //Ifall man väljer knappen med taggen "1" så är det rätt svar och man får ett poäng
            {
                score++;
            }

            if (qNum < 0) //Här går den till nästa fråga så länge talet inte skulle vara negativt, då resettar den till 0
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            scoreText.Content = "Answered Correctly" + score + "/" + questionNumbers.Count;

            NextQuestion();
        }

        private void RestartGame() //Startar om spelet genom att sätta alla värden till ordinarie värden och runnar StartGame commandet
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count) //Går till nästa fråga så länge det finns frågor kvar
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSeaGreen;
            }

            switch (i)
            {
                case 1:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Knight Garen";
                    answer2.Content = "Default Skin";
                    answer3.Content = "Warrior Garen";
                    answer4.Content = "Homo Garen";

                    answer2.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/1.jpg"));


                    break;

                case 2:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Commando Garen";
                    answer2.Content = "Sergeant Garen";
                    answer3.Content = "Leader Garen";
                    answer4.Content = "Legion Garen";

                    answer1.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/2.jpg"));


                    break;

                case 3:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Knight Garen";
                    answer2.Content = "Rugged Garen";
                    answer3.Content = "Dreadknight Garen";
                    answer4.Content = "Legion Garen";

                    answer3.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/3.jpg"));


                    break;

                case 4:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Adventurer Garen";
                    answer2.Content = "Admiral Garen";
                    answer3.Content = "Wanderer Garen";
                    answer4.Content = "Rugged Garen";

                    answer4.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/4.jpg"));


                    break;

                case 5:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Surge Garen";
                    answer2.Content = "Thunder Garen";
                    answer3.Content = "Steel Legion Garen";
                    answer4.Content = "Metal Legion Garen";

                    answer3.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/5.jpg"));


                    break;

                case 6:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Mercenary Garen";
                    answer2.Content = "Pirate Captain Garen";
                    answer3.Content = "Rogue Admiral Garen";
                    answer4.Content = "Captain Garen";

                    answer3.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/6.jpg"));


                    break;

                case 7:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Lion Warrior Garen";
                    answer2.Content = "God-King Garen";
                    answer3.Content = "Lion-Warrior garen";
                    answer4.Content = "God King Garen";

                    answer2.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/7.jpg"));


                    break;

                case 8:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Demacia Vice Garen";
                    answer2.Content = "Chad Garen";
                    answer3.Content = "Vice City Garen";
                    answer4.Content = "Synthwave Garen";

                    answer1.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/8.jpg"));


                    break;

                case 9:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Legion Garen";
                    answer2.Content = "Mechatron Garen";
                    answer3.Content = "Gundam Garen";
                    answer4.Content = "Mecha Kingdoms Garen";

                    answer4.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/9.jpg"));


                    break;

                case 10:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Monkey";
                    answer2.Content = "Young Garen";
                    answer3.Content = "Academy Garen";
                    answer4.Content = "Battle Academia Garen";

                    answer4.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/10.jpg"));


                    break;

                case 11:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Warrior Garen";
                    answer2.Content = "Leader Garen";
                    answer3.Content = "Sanguine Garen";
                    answer4.Content = "Admiral Garen";

                    answer3.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/11.jpg"));


                    break;

                case 12:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Sandy Garen";
                    answer2.Content = "Sandkingdom Garen";
                    answer3.Content = "Desert Trooper Garen";
                    answer4.Content = "Sandstorm Garen";

                    answer3.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/12.jpg"));


                    break;

                case 13:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Chinese Warrior Garen";
                    answer2.Content = "Warring Kingdoms Garen";
                    answer3.Content = "General Garen";
                    answer4.Content = "Festival Garen";

                    answer2.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/13.jpg"));


                    break;

                case 14:

                    textQuestion.Text = "Which Garen skin is this?";

                    answer1.Content = "Mecha Kingdoms Garen Prestige Edition";
                    answer2.Content = "Mecha KIngdoms Garen Prestige Edition";
                    answer3.Content = "Mecha Kingdoms Garen Prestigé Edition";
                    answer4.Content = "Mecha Kingdoms Garen Prestige Editión";

                    answer1.Tag = "1";

                    questionImage.Source = new BitmapImage(new Uri("pack://application:,,,/images/14.jpg"));


                    break;



            }

        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList(); //Randomar ordningen av frågorna

            questionNumbers = randomList;

            questionOrder.Content = null; //Tömmer contenten

            for (int i = 0; i < questionNumbers.Count; i++)
            {
                questionOrder.Content += " " + questionNumbers[i].ToString();
            }
        }
    }
}
