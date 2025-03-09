using System.Collections.Generic;

public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        Array.Sort(nums);
        int length = nums.Length;
        List<int> result = new List<int>();
        HashSet<int> numsSet = new HashSet<int>(nums);
        for( int j = 1; j <= length; j++)
        {
            if (!numsSet.Contains(j))
            {
                result.Add(j);
            }
        }
        return result;
    }
}
