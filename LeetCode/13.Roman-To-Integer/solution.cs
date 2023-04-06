using System.Collections.Generic;

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int n = s.Length;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            if (i + 1 < n && dict[s[i]] < dict[s[i + 1]])
            {
                sum -= dict[s[i]];
            }
            else
            {
                sum += dict[s[i]];
            }
        }
        return sum;
    }
}