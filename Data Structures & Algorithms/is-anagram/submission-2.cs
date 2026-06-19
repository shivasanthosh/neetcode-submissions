public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var countMap = new Dictionary<char, int>();

        // Count characters in s
        foreach (char c in s) {
            if (countMap.ContainsKey(c))
                countMap[c]++;
            else
                countMap[c] = 1;
        }

        // Decrement using characters in t
        foreach (char c in t) {
            if (!countMap.ContainsKey(c))
                return false; // character not in s

            countMap[c]--;
            if (countMap[c] < 0)
                return false; // too many of this character
        }

        return true;
    }
}