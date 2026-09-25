//Brutal force solution O(n^2)

public class Solution {
    public bool hasDuplicate(int[] nums) {
        for(int i = 0; i<nums.Length; i++){
        for(int j = i+1; j<nums.Length; j++){

        if(nums[i] == nums[j])
        return true;
        }
        }

        return false;
    }
}
