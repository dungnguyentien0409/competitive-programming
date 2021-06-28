class Solution(object):
    def candy(self, ratings):
        """
        :type ratings: List[int]
        :rtype: int
        """
        res = [1] * len(ratings)
        for i in range(len(ratings))[1::]:
            if ratings[i] > ratings[i - 1]:
                res[i] = res[i - 1] + 1
        for i in range(len(ratings) - 1)[::-1]:
            if ratings[i] > ratings[i + 1] and res[i] <= res[i + 1]:
                res[i] = res[i + 1] + 1
        print(res)
        return sum(res)
        