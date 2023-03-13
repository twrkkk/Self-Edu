using System.Collections.Generic;
using System.Linq;

namespace TextAnalysis
{
    static class FrequencyAnalysisTask
    {
        private static Dictionary<string, Dictionary<string, int>> GetAllNGramms(List<List<string>> text, int n)
        {
            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();

            foreach (var sent in text)
            {
                for (int i = 0; i < sent.Count - n + 1; i++)
                {
                    var startNGram = string.Join(" ", sent.GetRange(i, n - 1));
                    var endNGram = sent[i + n - 1];

                    if (!result.ContainsKey(startNGram))
                    {
                        var d = new Dictionary<string, int>();
                        d.Add(endNGram, 1);
                        result.Add(startNGram, d);
                    }
                    else
                    {
                        if (!result[startNGram].ContainsKey(endNGram))
                            result[startNGram].Add(endNGram, 1);
                        else
                            result[startNGram][endNGram]++;
                    }
                }
            }

            return result;
        }

        private static Dictionary<string, string> GetMostFrequentNGramm(Dictionary<string, Dictionary<string, int>> nGramms)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            foreach (var phrase in nGramms)
            {
                int maxLen = 0;
                string mostFreqStr = null;
                foreach (var ending in phrase.Value)
                {
                    if (ending.Value > maxLen)
                    {
                        mostFreqStr = ending.Key;
                        maxLen = ending.Value;
                    }
                    else if (ending.Value == maxLen && string.CompareOrdinal(ending.Key, mostFreqStr) < 0)
                    {
                        mostFreqStr = ending.Key;
                        maxLen = ending.Value;
                    }

                }

                result.Add(phrase.Key, mostFreqStr);
            }

            return result;
        }
        public static Dictionary<string, string> GetMostFrequentNextWords(List<List<string>> text)
        {
            return GetMostFrequentNGramm(GetAllNGramms(text, 2)
                                        .Concat(GetAllNGramms(text, 3))
                                        .ToDictionary(k => k.Key, v => v.Value));
        }
    }
}
