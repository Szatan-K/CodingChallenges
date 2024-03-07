# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def middleNode(self, head):
        """
        :type head: ListNode
        :rtype: ListNode
        """
        mid = head
        i = 0
        while head.next:
            if i % 2 == 0:
                mid = mid.next
            head = head.next
            i += 1
        return mid