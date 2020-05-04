using System.Collections.Generic;
using System.Text;
using Translit.Core.Languages;

namespace Translit.Core
{
    public sealed class Translit
    {
        private readonly Dictionary<string, string> _alphabet;

        public Translit(Language language)
        {
            Validator.CheckAlphabet(language);
            _alphabet = language.GetAlphabet();
        }

        public string GetString(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            var result = new StringBuilder();
            
            foreach (var symbol in text)
            {
                if (_alphabet[symbol.ToString()] != null)
                    result.Append(_alphabet[symbol.ToString()]);
            }

            return Validator.Check(result);
        }
    }
}
