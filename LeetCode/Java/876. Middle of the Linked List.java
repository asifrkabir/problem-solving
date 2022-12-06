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
    public ListNode middleNode(ListNode head) {
        ArrayList<ListNode> nodeList = new ArrayList<ListNode>();

        while(head != null) {
            nodeList.add(head);
            head = head.next;
        }

        return nodeList.get(nodeList.size() / 2);
    }
}