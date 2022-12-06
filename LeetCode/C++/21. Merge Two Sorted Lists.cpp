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
    ListNode *mergeTwoLists(ListNode *list1, ListNode *list2)
    {

        ListNode *mergedList = new ListNode();
        ListNode *currentNode = mergedList;

        while (list1 != nullptr || list2 != nullptr)
        {
            ListNode *newNode = new ListNode();

            if (list1 == nullptr)
            {
                currentNode->next = list2;
                break;
            }
            else if (list2 == nullptr)
            {
                currentNode->next = list1;
                break;
            }
            else if (list1->val <= list2->val)
            {
                newNode->val = list1->val;
                list1 = list1->next;
            }
            else
            {
                newNode->val = list2->val;
                list2 = list2->next;
            }

            currentNode->next = newNode;
            currentNode = newNode;
        }

        return mergedList->next;
    }
};