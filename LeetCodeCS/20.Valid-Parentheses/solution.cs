public class Solution {
    public bool IsValid(string s) {
        Dictionary<char, char> pairs = new Dictionary<char, char>() { {'(', ')'}, {'[', ']'}, {'{', '}'} };
        Stack<char> brackets = new Stack<char>();
        foreach (char c in s)
        {
            char top;
            Console.WriteLine(brackets.Count);
            Console.WriteLine(c);
            if (brackets.Count > 0)
            {
                top = brackets.Peek();
                if (pairs.ContainsKey(top))
                {
                    if (c == pairs[top])
                    {
                        brackets.Pop();
                        continue;
                    }
                }
            }
            brackets.Push(c);
        }
        if (brackets.Count > 0)
            return false;
        return true;
    }
}