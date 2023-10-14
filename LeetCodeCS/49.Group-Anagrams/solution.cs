public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<IList<string>> res = new List<IList<string>>();
        List<string> newStrs = strs.ToList();
        newStrs.Sort();
        while (newStrs.Count() > 0)
        {
            List<string> temp = new List<string>();
            string firstWord = newStrs[0];
            temp.Add(firstWord);
            Console.WriteLine(firstWord);
            Dictionary<char, int> countFirstWord = new Dictionary<char, int>();
            for (int i = 0; i < firstWord.Length; i++)
            {
                if (countFirstWord.ContainsKey(firstWord[i]))
                    countFirstWord[firstWord[i]] += 1;
                else
                    countFirstWord.Add(firstWord[i], 1);
            }
            List<string> indexesToRemove = new List<string>();
            for (int i = 1; i < newStrs.Count; i++)
            {
                string tempWord = newStrs[i];
                if (firstWord.Length != tempWord.Length)
                    continue;
                Dictionary<char, int> countTempWord = new Dictionary<char, int>();
                for (int j = 0; j < tempWord.Length; j++)
                    if (countTempWord.ContainsKey(tempWord[j]))
                        countTempWord[tempWord[j]] += 1;
                    else
                        countTempWord.Add(tempWord[j], 1);
                bool isValid = true;
                foreach (KeyValuePair<char, int> entry in countFirstWord)
                {
                    if (!countTempWord.ContainsKey(entry.Key))
                    {
                        isValid = false;
                        break;
                    }
                    if (countFirstWord[entry.Key] != countTempWord[entry.Key])
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    temp.Add(tempWord);
                    indexesToRemove.Add(tempWord);
                }
            }
            res.Add(temp);
            foreach (string s in indexesToRemove)
            {
                if (indexesToRemove.Count() == 1 && newStrs.Count == 1)
                    break;
                if (newStrs.Contains(s))
                    newStrs.Remove(s);
            }
            newStrs.RemoveAt(0);
            indexesToRemove.Clear();
        }
        return res;
    }
}