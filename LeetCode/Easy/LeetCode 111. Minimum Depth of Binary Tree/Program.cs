using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_111.Minimum_Depth_of_Binary_Tree
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
        private int helper(TreeNode root, int level)
        {
            int result = int.MaxValue;
            if(root.left == null && root.right == null)
            {
                result = Math.Min(result, level);
            }
            else
            {
                if (root.left != null)
                    result = Math.Min(helper(root.left, level + 1), result);
                if (root.right != null)
                    result = Math.Min(helper(root.right, level + 1), result);
            }

            return result;
        }
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            return helper(root, 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
