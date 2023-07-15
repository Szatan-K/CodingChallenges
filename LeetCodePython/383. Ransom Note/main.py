class Solution(object):
    def canConstruct(self, ransomNote, magazine):
        """
        :type ransomNote: str
        :type magazine: str
        :rtype: bool
        """
        available_letters = {}
        for letter in magazine:
            if letter not in available_letters:
                available_letters[letter] = 1
            else:
                available_letters[letter] += 1
        
        print(available_letters)

        for letter in ransomNote:
            if letter not in available_letters.keys() or available_letters[letter] <= 0:
                return False
            else:
                available_letters[letter] -= 1
        
        print(available_letters)
        return True