using System.Collections;
using System.Security.AccessControl;

namespace WorkShopCollectionOne
{
	internal class Program
	{
		static void Main(string[] args)
		{
            //1. Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //int[] numbers = { 11, 5, 3 };
            //int numOfQueries = 3;
            //         Helper.checkGreaterThanX(numbers, numOfQueries);
            //2. Given a number N and an array of N numbers. Determine if it's palindrome or not.


            //3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue inputQ = new Queue();
            //for(int i =0; i < 10; i++)
            //{
            //    inputQ.Enqueue(i);
            //}
            //inputQ = Helper.ReverseQueue(inputQ);
            //Console.WriteLine("Queue after Reverse");
            //foreach (var num in inputQ)
            //{
            //    Console.Write(num + " ");
            //}
            //4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string str = "[{}";
            //bool result = Helper.isBalanced(str);
            //Console.WriteLine($"IS experation balanced? ==> {result}");

            //5. Given an array, implement a function to remove duplicate elements from an array.

            //int[] arr = { 1, 2, 2, 3, 4, 1, 6, 3 };
            //arr = Helper.RemoveDuplicates(arr);
            //foreach (var num in arr)
            //{
            //    Console.Write(num + " ");
            //}

            //6. Given an array list , implement a function to remove all odd numbers from it.
            //ArrayList arrlist = new ArrayList() { 1 , 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Helper.RemoveOddNums(arrlist);
            //Console.WriteLine("ArrayList after removing odd numbers:");
            //foreach (var num in arrlist)
            //{
            //    Console.Write(num + " ");
            //}

            //7. Implement a queue that can hold different data types. 

            //Helper.CreateMixedQueue();

            //8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).


            //Stack<int> stack = new Stack<int>();
            //for (int i = 1; i <= 10; i++)
            //{
            //    stack.Push(i);
            //}
            //int target;
            //do
            //{
            //    Console.WriteLine("Please enter target to search in stack");
            //}
            //while (!int.TryParse(Console.ReadLine() , out target));
            //Helper.SearchTargetInStack(stack, target);
            //9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
            //int[] nums1 = { 1, 2, 3, 4, 4 };
            //int[] nums2 = { 10, 4, 4 };
            //int[] result  = Helper.IntersectionArray(nums1, nums2);
            //foreach (var num in result)
            //{
            //    Console.Write(num + " ");
            //}

            //10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
            //int size, element, targetSum;
            //do
            //{
            //    Console.WriteLine("Enter number of elements");
            //}
            //while (!int.TryParse(Console.ReadLine(),out size) || size <= 0);
            //ArrayList arrList = new ArrayList();
            //Console.WriteLine("Enter elements");
            //for(int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.WriteLine($"Enter element {i + 1}");
            //    }
            //    while (!int.TryParse(Console.ReadLine(), out element));
            //    arrList.Add(element);
            //}

            //do
            //{
            //    Console.WriteLine("Enter the target sum");
            //}
            //while (!int.TryParse(Console.ReadLine() , out targetSum));

            //Console.Clear();
            //ArrayList result = Helper.FindSumArray(arrList , targetSum);
            //foreach (var num in result)
            //{
            //    Console.Write(num + " ");
            //}
            //11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 
            Queue<int> queue = new Queue<int>();
            for(int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
            }
            int k = 3;
            Helper.ReverseKElements(queue, k);
            foreach (var num in queue)
            {
                Console.Write(num + " ");
            }

        }
    }
}
