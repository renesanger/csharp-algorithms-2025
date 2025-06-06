public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null){
            return true;
        }

        if(p != null && q != null && p.val == q.val){
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
        else{
            return false;
        }
    }
}
