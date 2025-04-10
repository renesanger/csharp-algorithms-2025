public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> complements = new Dictionary<int,int>();

        for(int i=0;i<nums.Length; i++){
            var complement = target - nums[i];
            if(complements.ContainsKey(complement)){
                return [complements[complement], i];
            }
            else{
                complements[nums[i]] = i;
            }
        }

        return [-1,-1];
    }
}
