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
        if head.next is None:
            return head
        
        items = 1
        x = head
        while x.next is not None:
            actual = x.next
            x = actual
            items += 1

        for x in range(items//2):
            actual = head.next
            head = actual
        return actual