using System;

namespace AlgorithmPrograms
{
    class Program
    {
         
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Bubble Sort,2-Binary search,3-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int[] arr1 = { 27,11,3,5,1 };
                        bubble.BubbleSortArray(arr1);
                        bubble.Print(arr1);
                        break;
                    case 2:
                        BinarySearch search = new BinarySearch();
                        int[] arr2 = { 2,7,10,23,45,67 };
                      int result= search.BinarySearching(arr2,0,5,45);
                        Console.WriteLine(result);
                       
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }



        }
    }
    
}
