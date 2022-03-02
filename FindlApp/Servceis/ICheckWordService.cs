using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindlApp.Servceis
{
    public interface ICheckWordService
    {
        bool Check(string guess);
        void ChooseNewWord();
        int Size { get; }
        string CurrentWord { get; }
    }
}
