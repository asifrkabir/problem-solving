/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public void DeleteNode(ListNode node) {
        var current = node;
        
        while(current.next.next != null)
        {
            current.val = current.next.val;
            current = current.next;
        }
        
        current.val = current.next.val;
        current.next = null;
    }
}