/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MiddleNode(ListNode head) {
        var current = head;
        var nodeCount = 0;
        
        while(current != null)
        {
            nodeCount++;
            current = current.next;
        }
        
        if(nodeCount == 1)
        {
            return head;
        }
        
        current = head;
        var middleIndex = nodeCount / 2;
        var currentIndex = 0;
        
        while(currentIndex != middleIndex)
        {
            current = current.next;
            currentIndex++;
        }
        
        return current;
        
    }
}