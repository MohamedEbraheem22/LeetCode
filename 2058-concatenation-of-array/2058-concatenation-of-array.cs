public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
        int [] ans = new int[nums.Length*2];
        for(int n = 0; n< nums.Length; n++)
        {
            ans[n] = nums[n];
            ans[n+nums.Length] = nums[n];
        }
        return ans;
    }
}