public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if(!numbers.ContainsKey(nums[i]))
            {
                numbers[nums[i]] = 1;
            }
            else
            {
                numbers[nums[i]] += 1;
            }
        }
        foreach(var key in numbers.Keys)
        {
            if(numbers[key] % 2 == 1)
            {
                return false;
            }
        }
        return true;
    }
}