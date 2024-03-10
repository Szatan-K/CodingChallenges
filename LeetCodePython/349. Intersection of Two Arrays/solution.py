class Solution(object):
    def intersection(self, nums1, nums2):
        """
        :type nums1: List[int]
        :type nums2: List[int]
        :rtype: List[int]
        """
        max_ = nums1 if len(nums1) > len(nums2) else nums2
        min_ = nums2 if len(nums1) > len(nums2) else nums1
        res = []
        for i in range(len(max_)):
            if max_[i] in min_ and max_[i] not in res:
                res.append(max_[i])
        return res
