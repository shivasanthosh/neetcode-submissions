class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        sd = {}
        for x in s:
            if x in sd:
                sd[x]+=1
            else:
                sd[x]=0
        td = {}
        for x in t: 
            if x in td:
                td[x]+=1
            else:
                td[x]=0

        return sd == td
         

        