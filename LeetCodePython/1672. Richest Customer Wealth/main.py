class Solution(object):
    def maximumWealth(self, accounts):
        """
        :type accounts: List[List[int]]
        :rtype: int
        """
        max = 0
        for customer in accounts:
            if sum(customer) > max:
                max = sum(customer)
        return max