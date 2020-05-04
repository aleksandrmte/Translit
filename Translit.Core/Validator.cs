using System;
using System.Linq;
using System.Text;
using Translit.Core.Languages;

namespace Translit.Core
{
    public class Validator
    {
        public static string Check(StringBuilder text)
        {
            if (text.Equals("-"))
                return "";

            if (text[0].Equals('-'))
                text.Remove(0, 1);

            if (text.Length <= text.Length - 1) 
                return text.ToString();

            if (text[text.Length - 1].Equals('-'))
                text.Remove(text.Length - 1, 1);

            return text.ToString();
        }

        public static void CheckAlphabet(Language language)
        {
            if (!language.GetAlphabet().Any())
                throw new Exception("Alphabet is empty");
        }
    }
}
