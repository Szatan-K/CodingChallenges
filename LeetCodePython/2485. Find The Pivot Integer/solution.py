class Solution(object):
    def pivotInteger(self, n):
        """
        :type n: int
        :rtype: int
        """
        sum_left = 0
        sum_right = 0
        i = 1
        j = n
        if n == 1:
            return 1
        else:
            while True:
                if i >= j:
                    if sum_left == sum_right:
                        return i
                    else:
                        return -1
                if sum_right < sum_left:
                    sum_right += j
                    j -= 1
                else:
                    sum_left += i
                    i += 1