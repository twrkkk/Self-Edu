using System;
using System.Collections.Generic;

namespace LeetCode_929._Unique_Email_Addresses
{
    class Program
    {
        public class Solution
        {
            public int NumUniqueEmails(string[] emails)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                foreach (var email in emails)
                {
                    var parts = email.Split('@');
                    int plusPos = parts[0].IndexOf('+');
                    string localName = parts[0].Substring(0, plusPos == -1 ? parts[0].Length : plusPos).Replace(".", "");
                    string adress = localName + "@" + parts[1];
                    if (!dict.ContainsKey(adress))
                        dict.Add(adress, 1);
                }
                return dict.Count;
            }
            public int NumUniqueEmails2(string[] emails)
            {
                HashSet<(string, string)> hash = new HashSet<(string, string)>();
                foreach (var email in emails)
                {
                    var parts = email.Split('@');
                    int plusPos = parts[0].IndexOf('+');
                    string localName = parts[0].Substring(0, plusPos == -1 ? parts[0].Length : plusPos).Replace(".", "");
                    if (!hash.Contains((localName, parts[1])))
                        hash.Add((localName, parts[1]));
                }
                return hash.Count;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
