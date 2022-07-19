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
    public int GetDecimalValue(ListNode head) {
        var current = head;
        var bitstring = string.Empty;
        
        while(current != null)
        {
            bitstring += current.val;
            current = current.next;
        }
        
        return Convert.ToInt32(bitstring, 2);
    }
}