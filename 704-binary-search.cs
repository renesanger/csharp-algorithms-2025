public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0,r = nums.Length-1;
        while(l<=r){
            int middle = l+((r-l)/2);
            if(target<nums[middle]){
                r = middle-1;
            }
            else if(target>nums[middle]){
                l = middle+1;
            }
            else{
                return middle;
            }
        }
        return -1;
    }
}
