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
    public int getDecimalValue(ListNode head) {
        String binaryString = "";
        int output = 0;

        while(head != null) {
            binaryString += head.val;
            head = head.next;
        }

        output = Integer.parseInt(binaryString, 2);
        return output;
    }
}