using System.Collections.Generic;

namespace TextAnalysis
{
    static class SentencesParserTask
    {
        public static List<List<string>> ParseSentences(string text)
        {
            var sentencesList = new List<List<string>>();
            char[] delimiters = { '.', '!', '?', ';', ':', '(', ')' };
            foreach (var sentence in text.Split(delimiters))
            {
                if (sentence.Length > 0)
                {
                    List<string> ListOfWords = DevideByWords(sentence);
                    if (ListOfWords != null && ListOfWords.Count > 0)
                        sentencesList.Add(ListOfWords);
                }
            }
            return sentencesList;
        }

        private static List<string> DevideByWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) return null;
            List<string> result = new List<string>();
            var words = sentence.Split(' ');//new char[] { ' ', ',', '\n', '\r', '\t' });
            foreach (var word in words)
            {
                foreach (var item in RemoveSeparators(word).Split(' '))
                {
                    if (!string.IsNullOrEmpty(item))
                        result.Add(item.ToLower());
                }

            }
            return result;
        }

        private static string RemoveSeparators(string word)
        {
            int length = word.Length;
            for (int i = 0; i < length; i++)
            {
                if (!char.IsLetter(word[i]) && word[i] != '\'')
                    word = word.Replace(word[i], ' ');
            }
            return word;
        }

    }
}