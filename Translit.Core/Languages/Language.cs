using System.Collections.Generic;

namespace Translit.Core.Languages
{
    public abstract class Language
    {
        protected Dictionary<string, string> Alphabet { get; set; }

        protected Language()
        {
            Alphabet = new Dictionary<string, string>();
        }

        public Dictionary<string, string> GetAlphabet()
        {
            return Alphabet;
        }

        protected abstract void FillAlphabet();
    }
}
