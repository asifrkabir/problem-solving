/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution
{
public:
    ListNode *deleteDuplicates(ListNode *head)
    {

        ListNode *originalHead = head;
        ListNode *currentNode = head;
        int currentVal = -101;

        while (head != nullptr)
        {
            if (head->val != currentVal)
            {
                currentVal = head->val;
                currentNode = head;
            }
            else
            {
                currentNode->next = head->next;
            }

            head = head->next;
        }

        return originalHead;
    }
};