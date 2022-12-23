using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class Stack
    {
        //Creating node
        public Node top;
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }
        //Peek method: It gives the top most element in stack without removing the element.
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Console.WriteLine("The element after peeking is : " + this.top.data);
        }
        //Pop method: It removes the top most element
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("No elements present in the stack");
                return;
            }
            Peek();
            this.top = this.top.next;
        }
        //Checking the any underflow or overflow occurs(size of stack)
        public void IsEmpty()                               // IsEmpty: checking stack is empty 
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
        // displaying node
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("None value be added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Stack contains node:" + temp.data);
                temp = temp.next;
            }
        }
    }
}
