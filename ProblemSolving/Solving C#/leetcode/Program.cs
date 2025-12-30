using System.Xml;

namespace leetcode
{

    internal class Program
    {
        
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
                {
                    this.val = val;
                    this.next = next;
                }
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                int remainder = 0;
                ListNode result = new ListNode();
                ListNode resultTemp = result;
                while (l1 != null || l2 != null)
                {
                    int upperNodeValue = 0;
                    int lowerNodeValue = 0;
                    if (l1 != null)
                    {
                        upperNodeValue = l1.val;
                        l1 = l1.next;
                    }
                    if(l2 != null)
                    {
                        lowerNodeValue = l2.val;
                        l2 = l2.next;
                    }
                    
                    ListNode tempNode = new ListNode((upperNodeValue+lowerNodeValue+remainder )%10,null);
                    remainder = (upperNodeValue + lowerNodeValue + remainder) / 10;
                    resultTemp.next = tempNode;
                    resultTemp = tempNode;
                }
                return result.next;
            }
        }
        static void Main(string[] args)
        {
           
            
            ListNode l3 = new ListNode(3, null);
            ListNode l2 = new ListNode(4, l3);
            ListNode l1 = new ListNode(2, l2);


            ListNode L3 = new ListNode(4, null);
            ListNode L2 = new ListNode(6, L3);
            ListNode L1 = new ListNode(5, L2);
            ListNode temp = l1; //start;
            //while (l1 != null)
            //{
            //    Console.WriteLine(l1.val+" ");
            //    l1 = l1.next;
            //}
            //while (L1 != null)
            //{
            //    Console.WriteLine(L1.val + " ");
            //    L1 = L1.next;
            //}

            Solution result = new Solution();
            ListNode N =  result.AddTwoNumbers(l1, L1);


            while (N != null)
            {
                Console.WriteLine(N.val + " ");
                N = N.next;
            }

        }

    }
}
