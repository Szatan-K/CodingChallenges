public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for( int i = 0; i < nums.Length; i++)
        {
            int valueToFind = target - nums[i];
            int index = Array.IndexOf(nums, valueToFind);
            if (index >= 0 && index != i)
            {
                return new int[] {i, index};
            }
        }
        return new int[] {0, 0};
    }
}