﻿using System;
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

namespace ExpertSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Quiz quiz;
        Question currentQuestion;
        public MainWindow()
        {
            InitializeComponent();
            quiz = JsonParser.generateQuiz();
            currentQuestion = quiz.currentQuestion;
            
            answersField.ItemsSource = currentQuestion.answers;
            questionField.Text = currentQuestion.questionText;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string content = (sender as Button).Content.ToString();
            Answer answer = currentQuestion.answers.FirstOrDefault(ans => ans.answer == content);
            bgGrid.Background = Brushes.Beige;
            if(content == "Restart")
            {
                this.RestartQuiz();
                return;
            }
            if(answer.resultOfQuiz != null)
            {
                questionField.Text = "Twoj jezyk programowania to " + answer.resultOfQuiz;
                bgGrid.Background = Brushes.LightGreen;
                answersField.ItemsSource = new List<Answer>() { new Answer("Restart", "", null) };
                return;
            }
            currentQuestion = answer.nextQuestion;
            answersField.ItemsSource = currentQuestion.answers;
            questionField.Text = currentQuestion.questionText;
        }

        private void RestartQuiz()
        {
            currentQuestion = quiz.currentQuestion;
            answersField.ItemsSource = currentQuestion.answers;
            questionField.Text = currentQuestion.questionText;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.R)
            {
                bgGrid.Background = Brushes.Beige;
                this.RestartQuiz();
            }
        }
    }
}
