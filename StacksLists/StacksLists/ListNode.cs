using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksLists
{
    class ListNode
    {
        public object Data { get; private set; } //Property for the object Data, so that the nodes content can be changed or retrieved
        public ListNode Next { get; private set; } //Property for the Next Node so that a new Data can be added to the stack


        public ListNode(object dataValue, ListNode nextNode) // Constructor to create the first node
        {
            Data = dataValue;
            Next = nextNode;
        }

       
    }
}
