using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindlApp.Servceis
{
    public class CheckWordService
    {
        List<string> m_words = new List<string>();
        string m_currentWord;

        public CheckWordService()
        {
            string[] words = System.IO.File.ReadAllLines("words - simple.txt");
            foreach (string line in words)
            {
                m_words.Add(line);
            }
        }

        public bool Check(string guess)
        {
            return m_words.Contains(guess);
        }

        public int Size => m_words.Count;

        public void ChooseNewWord()
        {
            Random random = new Random();
            int index = random.Next(Size);
            m_currentWord = m_words.ElementAt(index);
        }

        public string CurrentWord => m_currentWord;
    }
}
