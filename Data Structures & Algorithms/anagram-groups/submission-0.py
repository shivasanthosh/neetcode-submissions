class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        maps = defaultdict(list)
        for s in strs:
            sort_string = ''.join(sorted(s))
            maps[sort_string].append(s)
        
        return list(maps.values())
        