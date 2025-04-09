public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        /*
            Notes:
            It is better to use HashSet over a dictionary because keeping track of frequency of a number is not necessary

            “I’m using a HashSet here because I only care about uniqueness, not storing any additional data. If I needed to count occurrences, I’d reach for a Dictionary instead.”

            C# Syntax: Add returns false if the element already exists
        */

        var seen = new HashSet<int>();

        foreach(var num in nums){
            if(!seen.Add(num)){
                return true;
            }
        }
        return false;
    }
}
