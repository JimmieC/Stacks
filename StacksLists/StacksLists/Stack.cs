using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksLists
{
    class Stack
    {
        ListNode firstNode; //Declare ListNode from Class ListNode

        public int count = 0; //Declare and initialize variable count that will keep track of how many items are in the stack
        public void Push(object data) // Method to add new items to the stack(in data is variable object data)
        {
            ListNode newNode = new ListNode(data, firstNode); //Create new object of Class ListNode with parameters data from inparameter and firstNode

            firstNode = newNode; 

            if (firstNode == null) //If the stack is empty then the indata firstnode is equal to a new listnode
            {
                firstNode = new ListNode(data, null);
            }
            count = count + 1; //Count +1 to indicate something was added to the stack
        }
        public object Pop() //Method to remove top item from the stack
        {
            if (firstNode == null) // If the stack is empty then return value null
            {
                return null;
            }
            else // Otherwise
            {
                count = count - 1;        // -1 to the count to indicate the stack has one less item 
                object data = firstNode.Data; // Create an object data that is equal to the top of the stacks item
                firstNode = firstNode.Next; // The firstnode is now equal to the next thing in the stack
                return data; //return the data that has now been removed from the stack
            }
        }
        public object Peek() //Method to return whatever is on top of the stack
        {
            if (firstNode == null) //Same as Pop
            {
                return null;
            }
            else
            {
                object data = firstNode.Data; // Data is equal to the first object
                return data; // Return Data
            }
        }

        public void stackCountTerminate() //Method that increases the count by 99
        {
            count = count + 99;
            
        }
        public int stackCountGet() //method to return the count value as an int
        {
            return count;
        }

    }
}
