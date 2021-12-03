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
                Console.WriteLine("Enter your Choice Number to Execute the Program Press- 1-Bubble Sort,2-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        int[] arr1 = { 27,11,3,5,1 };
                        bubble.BubbleSortArray(arr1);
                        bubble.Print(arr1);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }



        }
    }
    
}
