public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        var temp = nums.ToArray();
        var result = new int[nums.Length];
        Array.Sort(temp);
        for (int i = 0; i < temp.Length; i++)
        {
            if (dict.ContainsKey(temp[i]))
            {
                continue;
            }
            else
            {
                dict[temp[i]] = i;
            }
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = dict[nums[i]];
        }
        return result;
    }
}