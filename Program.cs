﻿namespace cSharp_SortingAlgos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 5,2,9,7,8};
            BubbleSort(list);
            Console.Write("Selection Sort: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            printList(list);

            Console.Write("Merge Sort: ");
           // MergeSort(list);
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }

        public static void BubbleSort(List<int> list)
        {
            int n = list.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1 ; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j+1];
                        list[j+1] = temp;
                    }
                }
            }

            static void sort(List<int> list)
            {

                int n = list.Count;

                // One by one move boundary of unsorted subarray
                for (int i = 0; i < n - 1; i++)
                {
                    // Find the minimum element in unsorted list
                    int min_idx = i;
                    for (int j = i + 1; j < n; j++)
                        if (list[j] < list[min_idx])
                            min_idx = j;

                    // Swap the found minimum element with the first
                    // element
                    int temp = list[min_idx];
                    list[min_idx] = list[i];
                    list[i] = temp;
                }
            }
        }

        // Prints the list
        static void printList(List<int> list)
        {
            int n = list.Count;
            Console.Write("Selection Sort: ");
            for (int i = 0; i < n; ++i)
                Console.Write(list[i] + " ");
            Console.WriteLine();
                
        }

        public static void MergeSort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return;
            }

            int mid = list.Count / 2;
            List<int> left = list.GetRange(0, mid);
            List<int> right = list.GetRange(mid, list.Count - mid);

            MergeSort(left);
            MergeSort(right);
            Merge(list, left, right);
        }

        public static void Merge(List<int> list, List<int> left, List<int> right)
        {
            int i = 0, j = 0, k = 0;
             while (i < left.Count && j < right.Count)
             {
                if (left[i] < right[j])
                {
                    list[k] = left[i];
                    i++;
                }
                else
                {
                    list[k] = right[j];
                    j++;
                }
                k++;
             }

             while(i < left.Count)
             {
                list[k] = left[i];
                i++;
                k++;
             }

             while (j < right.Count)
            {
                list[k] = right[j];
                j++;
                k++;
            }
        }
    }
}