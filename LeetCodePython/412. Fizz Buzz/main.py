class Solution(object):
    def fizzBuzz(self, n):
        """
        :type n: int
        :rtype: List[str]
        """
        res = []
        for x in range(n):
            x += 1
            if x % 3 == 0 and x % 5 == 0:
                res.append('FizzBuzz')
            elif x % 5 == 0:
                res.append('Buzz')
            elif x % 3 == 0:
                res.append('Fizz')
            else:
                res.append(str(x))
        return res