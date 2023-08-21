public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums.Count() != nums.Distinct().Count())
        {
            return true;
        }
        return false;
    }
}
