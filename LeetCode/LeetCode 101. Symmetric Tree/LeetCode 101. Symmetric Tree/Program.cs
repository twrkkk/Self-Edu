using System;
using System.Collections.Generic;

namespace LeetCode_101._Symmetric_Tree
{
    
    public class Solution
    {
        
    }
    class Program
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static void Helper(TreeNode root, List<int> list)
        {
            if (root != null)
            {
                Helper(root.left, list);
                list.Add(root.val);
                Helper(root.right, list);
            }
        }
        public static bool IsSymmetric(TreeNode root)
        {
            List<int> res = new List<int>();
            Helper(root, res);
            if (res.Count % 2 == 0) return false;
            int mid = res.Count / 2;
            int i = 0;
            while (i < mid && res[mid + i] == res[mid - i])
                ++i;
            return i == mid;
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(2), null), new TreeNode(2, new TreeNode(2)));
            Console.WriteLine(IsSymmetric(root));
        }
    }
}
