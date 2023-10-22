public class Solution {
    public int StrStr(string haystack, string needle) {
        int maxi = haystack.Length - needle.Length + 1;
        for(int i = 0; i < maxi; i++)
        {   
            string res = haystack.Substring(i, needle.Length);
            if (string.Equals(res, needle))
                return i;
        }
        return -1;
    }
}