using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct.DataStructClasses
{
    internal class StaticStack
    {
        int tos ;
        int[] arr;
        int size;
        public StaticStack(int size)
        {
            this.size = size;
            tos = -1;
            arr = new int[size];
        }
        public void push(int val)
        {
            if (isFull() == false)
            {
                tos++;
                arr[tos] = val;
                Console.WriteLine($"Succesfully Added {val}");
            }
            else
                Console.WriteLine($"Stack is full");
        }
        public void pop() 
        {
            if (isEmpty() == false)
            {
                int temp = arr[tos];
                tos--;
                Console.WriteLine($"Succesfully removed {temp}");
            }
            else
            {
                Console.WriteLine($"Stack is Empty");
            }
        }
        public void peek()
        {
            int temp = arr[tos];
            Console.WriteLine($"Peek Value is {temp}");
        }
        public bool isEmpty()
        {
            if(tos < 0 )
            {
                return true;
            }
            return false;
        }
        public bool isFull()
        {
            if (tos>=size-1)
            {
                return true;
            }
            return false;
        }
        public void showStack()
        {
            for(int i=tos; i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
