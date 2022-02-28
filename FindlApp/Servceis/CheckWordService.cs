using FindlApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindlApp.Servceis
{
    public class CheckWordService
    {
        Words m_words;
        string m_currentWord;

        public CheckWordService(Words words)
        {
            m_words = words;
        }

        public bool Check(string guess)
        {
            return m_words.Exists(guess);
        }

        public void ChooseNewWord()
        {
            Random random = new Random();
            int r = random.Next(m_words.Size);
            m_currentWord = m_words.Get(r);
        }

        public string CurrentWord => m_currentWord;
    }
}
