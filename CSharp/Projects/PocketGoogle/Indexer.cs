using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        private Dictionary<string, Dictionary<int, List<int>>> _container = new Dictionary<string, Dictionary<int, List<int>>>(); //word - id - pos of start word in text
        public void Add(int id, string documentText)
        {
            List<string> text = documentText.Split(new[] { ' ', '.', ',', '!', '?', ':', '-', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            int pos = 0;
            foreach (string word in text)
            {
                pos = documentText.IndexOf(word, pos);
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if (!_container.ContainsKey(word))
                        _container.Add(word, new Dictionary<int, List<int>>());
                    if (!_container[word].ContainsKey(id))
                        _container[word].Add(id, new List<int>());
                    _container[word][id].Add(pos);
                    pos += word.Length;
                }
            }
        }

        public List<int> GetIds(string word)
        {
            return _container.ContainsKey(word) ? _container[word].Keys.ToList() : new List<int>();
        }

        public List<int> GetPositions(int id, string word)
        {
            bool flag = _container.ContainsKey(word) && _container[word].ContainsKey(id);
            return flag ? _container[word][id].ToList() : new List<int>();
        }

        public void Remove(int id)
        {
            foreach (var pair in _container)
            {
                if (_container[pair.Key].ContainsKey(id))
                    _container[pair.Key].Remove(id);
            }
        }
    }
}
