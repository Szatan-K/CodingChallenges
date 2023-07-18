class Solution(object):
    def isValid(self, s):
        """
        :type s: str
        :rtype: bool
        """
        bracket_dict = {'(': ')', '[':']', '{':'}'}
        opened = []
        for bracket in s:
            if bracket in '([{':
                opened.append(bracket)
            else:
                if not opened:
                    return False
                elif bracket == bracket_dict[opened[-1]]:
                    opened.pop()
                else:
                    return False

        return not opened