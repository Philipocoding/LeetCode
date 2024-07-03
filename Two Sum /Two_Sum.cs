public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int [] result = new int[2];
        
        for(int i = 0; i < nums.Length - 1; i++)
        {
            for(int ii = 1; ii < nums.Length; ii++)
            {
                if(nums[ii] + nums[i] == target){
                    result[0] = i;
                    result[1] = ii;
                    
                }            
            }
        }
        return result;
    }
}
