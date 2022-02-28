using FindlApp.Models;
using FindlApp.Servceis;
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

namespace FindlApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CheckWordService m_checkWordService;
        int m_guessNumber;

        public MainWindow()
        {
            InitializeComponent();
            m_checkWordService = new CheckWordService(new Words());
            m_guessNumber = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            m_checkWordService.ChooseNewWord();
            m_answer.Text = m_checkWordService.CurrentWord;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string guess = GetWord();
            m_check.IsChecked = m_checkWordService.Check(guess);
        }

        private string GetWord()
        {
            string word = string.Empty;

            if (m_guessNumber == 0)
            {
                word = m_guess1letter1.Text + m_guess1letter2.Text + m_guess1letter3.Text + m_guess1letter4.Text + m_guess1letter5.Text;
            }

            return word;
        }
    }
}
