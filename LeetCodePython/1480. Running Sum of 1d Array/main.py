class Solution(object):
    def runningSum(self, nums):
        """
        :type nums: List[int]
        :rtype: List[int]
        """
        res = []
        res.append(nums[0])
        for x in range(len(nums)-1):
            res.append(res[x]+nums[x+1])
        return res
    
#class Solution(object):
#    def runningSum(self, nums):
#        """
#        :type nums: List[int]
#        :rtype: List[int]
#        """
#        res = []
#        for x in range(len(nums)):
#            res.append(sum(nums[0:x+1]))
#        return res