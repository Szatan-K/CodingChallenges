public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> countS = new Dictionary<char, int>();
        Dictionary<char, int> countT = new Dictionary<char, int>();
        if (s.Length != t.Length)
            return false;
        for (int i = 0; i < s.Length; i++)
        {
            if(countS.ContainsKey(s[i]))
                countS[s[i]] += 1;
            else
                countS.Add(s[i], 1);
            if (countT.ContainsKey(t[i]))
                countT[t[i]] += 1;
            else
                countT.Add(t[i], 1);
        }
        
        foreach (KeyValuePair<char, int> c in countS)
        {
            if (!countT.ContainsKey(c.Key))
                return false;
            if (countS[c.Key] != countT[c.Key])
                return false;
        }
        return true;
    }
}