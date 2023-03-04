using System;
using System.Collections.Generic;

namespace LeetCode_145._Binary_Tree_Postorder_Traversal
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

    public class Solution
    {
        public void Helper(List<int> res, TreeNode node)
        {
            if(node != null)
            {
                Helper(res, node.left);
                Helper(res, node.right);
                res.Add(node.val);
            }
        }
        public List<int> PostorderTraversal(TreeNode root)
        {
            List<int> res = new List<int>();
            Helper(res, root);
            return res;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
