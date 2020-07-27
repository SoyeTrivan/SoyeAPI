using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyeAPI
{
    public class DOJScriptHelper
    {
        public static string ScriptLocation()
        {
            string textFile = Directory.GetCurrentDirectory() + @"\config\location.txt";
            string text = File.ReadAllText(textFile);

            string x = Directory.GetCurrentDirectory() + @"\resources\" + text + @"\";
            return x;
        }

        public static string BotToken()
        {
            string textFile = Directory.GetCurrentDirectory() + @"\config\token.txt";
            string text = File.ReadAllText(textFile);

            string x = text;
            return x;
        }
    }
}
