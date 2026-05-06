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
    public ListNode ReverseList(ListNode head) {
        if (head == null) return null;
        ListNode current = head;
        Stack<int> val = new Stack<int>();

        while (current != null){
            val.Push(current.val);
            current = current.next;
        }
        ListNode newHead = new ListNode(val.Pop());
        ListNode tail = newHead;

        while (val.Count > 0){
            ListNode sig = new ListNode(val.Pop());
            tail.next = sig;
            tail = tail.next;            
            

        }
        return newHead;
    }
}
