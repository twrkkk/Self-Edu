using System.Collections.Generic;

namespace TextAnalysis
{
    static class TextGeneratorTask
    {
        public static string ContinuePhrase(
            Dictionary<string, string> nextWords,
            string phraseBeginning,
            int wordsCount)
        {
            return nextWords.ContainsKey(phraseBeginning)? nextWords[phraseBeginning] : "No endigng for this phrase";
        }
    }
}