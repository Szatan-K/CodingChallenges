class Solution(object):
    def twoSum(self, nums, target):
        """
        :type nums: List[int]
        :type target: int
        :rtype: List[int]
        """
        numDict = {}
        n = len(nums)

        for i in range(n):
            dif = target - nums[i]

            if dif in numDict:
                return [numDict[dif], i]
            numDict[nums[i]] = i
        