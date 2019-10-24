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
            
            if(answer.resultOfQuiz != null)
            {
                questionField.Text = answer.resultOfQuiz;
                answersField.ItemsSource = new List<Answer>() { new Answer("Restart", "", null) };
                return;
            }
            if(content == "Restart")
            {
                currentQuestion = quiz.currentQuestion;
            }
            else 
            {
                currentQuestion = answer.nextQuestion;
            }
            answersField.ItemsSource = currentQuestion.answers;
            questionField.Text = currentQuestion.questionText;
        }
    }
}
