/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode oddEvenList(ListNode head) {
        if(head == null || head.next == null || head.next.next == null) {
            return head;
        }

        ListNode originOdd = head;
        ListNode oddNode = head;
        ListNode originEven = head.next;
        ListNode evenNode = head.next;
        head = head.next.next;

        while(head != null) {
            oddNode.next = head;
            evenNode.next = head.next;
            oddNode = oddNode.next;
            oddNode.next = originEven;
            evenNode = evenNode.next;

            if(evenNode == null) {
                break;
            }

            head = evenNode.next;
        }

        return originOdd;
    }
}