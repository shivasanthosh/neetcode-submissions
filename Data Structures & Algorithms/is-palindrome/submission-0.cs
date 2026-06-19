public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;

        while(l<r)
        {
            if(!IsAlphaNum(s[l]))
            {
                l++;
                continue;
            }
            if(!IsAlphaNum(s[r]))
            {
                r--;
                continue;
            }
            if(s[l].ToString().ToLower()!=s[r].ToString().ToLower())
            {
                return false;
            }
            l++;
            r--;

        }
        return true;
        
    }

    bool IsAlphaNum(char c)
    {
        if('a' <= c && c <= 'z' || 'A' <= c && c <= 'Z' || '0' <= c && c <= '9')
        {
            return true;
        }
        return false;
    }
}
