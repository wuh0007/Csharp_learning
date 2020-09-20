using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SummarizingTextProb
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is a long sentence .... LOL LLLLOL OLLLOOL LLoL";
            var summary = StringUtility.SummarizeText(sentence, 25);
            Console.WriteLine(summary);
        }

    }
}
