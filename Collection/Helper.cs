using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopCollectionOne
{
	public static class Helper
	{

        //2. Given a number N and an array of N numbers. Determine if it's palindrome or not.
        public static void checkGreaterThanX(int[] arr, int numOfQueries)
        {
            for (int i = 0; i < numOfQueries; i++)
            {
                int x;
                do
                {
                    Console.WriteLine("Please enter the Query number");
                }
                while (!int.TryParse(Console.ReadLine(), out x));
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (x < arr[j])
                        count++;
                }
                Console.WriteLine($"There are {count} numbers greater than {x} in the array.");
            }
        }

                //3. Given a Queue, implement a function to reverse the elements of a queue using a stack.
        public static Queue ReverseQueue(Queue inputQ)
        {
            Stack temp = new Stack();
            int n = inputQ.Count;
            while (inputQ.Count> 0)
            {
                temp.Push(inputQ.Dequeue());
            }
            while (temp.Count> 0)
            {
                inputQ.Enqueue(temp.Pop());
            }
            return inputQ;
        }

                //4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
        public static bool isPair(char open , char close)
        {
            if (open == '(' && close == ')')
                return true;
            if (open == '[' && close == ']')
                return true;
            if (open == '{' && close == '}')
                return true;
            return false;
        }

        public static bool isBalanced(string exp)
        {
            Stack<char> stack = new Stack<char>();
            int length = exp.Length;
            for(int i= 0; i<length; i++) { 
                if (exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
                    stack.Push(exp[i]);
                else if (exp[i] == ')' || exp[i] == '}' || exp[i] == ']')
                {
                    if(stack.Count == 0 || !isPair(stack.Peek(), exp[i]))
                    {
                        return false;
                    }else
                    {
                        stack.Pop();
                    }
                }
            }
            return stack.Count == 0 ? true : false;


        }
                //5. Given an array, implement a function to remove duplicate elements from an array.

        public static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> uniqueElements = new HashSet<int>(arr);
            arr = uniqueElements.ToArray();
            return arr;
        }

        //6. Given an array list , implement a function to remove all odd numbers from it.

        public static void RemoveOddNums(ArrayList arrList)
        {
            for(int i =0; i<arrList.Count; i++)
            {
                if (arrList[i] is int && (int)arrList[i] % 2 != 0)
                    arrList.RemoveAt(i);

            }
        }

        //7. Implement a queue that can hold different data types. 
        //And insert the following data:
        // queue.Enqueue(1)
        // queue.Enqueue(“Apple”)
        //queue.Enqueue(5.28)


        public static void CreateMixedQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);
            foreach (var num in queue)
            {
                Console.WriteLine(num + " ");
            }
        }
        //8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).
        //1 2 3 4 5 
        public static void SearchTargetInStack(Stack<int> stack , int target)
        {
            bool flag = false;
            int count = 0;
            foreach (var item in stack)
            {
                count++;
                if (item == target)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }

        //9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.
        public static int[] IntersectionArray(int[] nums1 , int[] nums2)
        {
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            foreach (var num in nums1)
            {
                if (numCount.ContainsKey(num))
                    numCount[num]++;
                else
                {
                    numCount[num] = 1;
                }
            }

            List<int> intersection = new List<int>();
            foreach (var num in nums2)
            {
                if(numCount.ContainsKey(num) && numCount[num] > 0)
                {
                    intersection.Add(num);
                    numCount[num]--;
                }
            }
            return intersection.ToArray();
        }

        //10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.
        public static ArrayList FindSumArray(ArrayList arrayList, int targetsum)
        {
            ArrayList result = new ArrayList();
            int sum = 0;
            int startIndex = 0;
            for(int endIndex = 0; endIndex< arrayList.Count ; endIndex++)
            {
                sum += (int)arrayList[endIndex];
                while(sum > targetsum && startIndex <= endIndex)
                {
                    sum-= (int)arrayList[startIndex];
                    startIndex++;
                }
                if (sum == targetsum)
                {
                    result = new ArrayList(arrayList.GetRange(startIndex , endIndex - startIndex +1));
                    break;
                }
                    

            }
            return result;
        }
        //11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

        public static void ReverseKElements(Queue<int> queue, int K)
        {
            if (K <=0 && K>= queue.Count)
            {
                throw new Exception("Invalid value of K");

            }
            Stack<int> stack = new Stack<int>();
            // 1 2 3 4 5
            for(int i = 0; i< K ; i++)
            {
                stack.Push(queue.Dequeue());
                //1 2 3 
            }
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
            //4 5 3 2 1
            for(int i = 0; i < queue.Count; i++)
            {
                queue.Enqueue(queue.Dequeue());
                //3 2 1 4 5 
            }

        }
    }
}
