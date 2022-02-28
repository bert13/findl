using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindlApp.Models
{
    public class Words
    {
        List<string> m_words = new List<string>();
        public Words()
        {
            string[] words = System.IO.File.ReadAllLines("words - simple.txt");
            foreach (string line in words)
            {
                m_words.Add(line);
            }
        }

        public int Size => m_words.Count;

        public string Get(int index)
        {
            return m_words.ElementAt(index);
        }

        public bool Exists(string word)
        {
            // return true/false if the word exists in the list of strings
            return m_words.Contains(word);
        }
    }
}
