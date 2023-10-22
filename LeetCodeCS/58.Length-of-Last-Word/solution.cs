public class Solution {
    public int LengthOfLastWord(string s) {
        string[] tab = s.Trim().Split(' ');
        return tab[tab.Length-1].Length;
    }
}