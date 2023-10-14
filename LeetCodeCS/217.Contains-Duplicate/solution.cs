using System.Collections.Generic;
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (count.ContainsKey(nums[i]))
            {
                return true;
            }
            else
                count.Add(nums[i], 1);
        }
        return false;
    }
}