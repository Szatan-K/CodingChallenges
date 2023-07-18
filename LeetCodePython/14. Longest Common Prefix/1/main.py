class Solution(object):
    def longestCommonPrefix(self, strs):
        """
        :type strs: List[str]
        :rtype: str
        """
        ans = ''

        strs = sorted(strs)

        for i in range(len(strs[0])):
            if strs[0][i] != strs[-1][i]:
                return ans
            else:
                ans += strs[0][i]


        return ans