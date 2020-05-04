using System;
using Translit.Core.Languages;
using Xunit;

namespace Translit.Tests
{
    public class GeneralTest
    {
        [Fact]
        public void EmptyAlphabetTest()
        {
            Assert.Throws<Exception>(() => new Core.Translit(new CustomLanguage()));
        }

        private class CustomLanguage: Language
        {
            protected override void FillAlphabet()
            {}
        }

        [Fact]
        public void StringSimpleTest()
        {
            var result = new Core.Translit(new RussianLanguage()).GetString("программирование");
            Assert.Equal("programmirovanie", result);
        }

        [Fact]
        public void StringHyphenTest()
        {
            var result = new Core.Translit(new RussianLanguage()).GetString("-машина-");
            Assert.Equal("mashina", result);
        }

        [Fact]
        public void StringEmptyTest()
        {
            var result = new Core.Translit(new RussianLanguage()).GetString("");
            Assert.Equal("", result);
        }
    }
}
