public class Solution {
    public int DiameterOfBinaryTree(TreeNode root) {
        int res = 0;
        DFS(root, ref res);
        return res;
    }

    private int DFS(TreeNode root, ref int res) {
        if (root == null) {
            return 0;
        }
        int left = DFS(root.left, ref res);
        int right = DFS(root.right, ref res);
        res = Math.Max(res, left + right);
        return 1 + Math.Max(left, right);
    }
}
