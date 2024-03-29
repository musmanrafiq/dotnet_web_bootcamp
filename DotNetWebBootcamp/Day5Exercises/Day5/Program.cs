﻿using System.Globalization;

namespace Day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectionSort();
        }

        public static void BubbleSort()
        {
            int[] arr = { 80, 11, 590, 771, 9, 770, 240, 9 };
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        int temp = 0;
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
        public static void InsertionSort()
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int n = 10, i, j, val, flag;
            Console.WriteLine("Insertion Sort\n\n");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n\n ");

            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Console.Write("Sorted Array is: ");
         for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public static void SelectionSort()
        {
            int[] arr = new int[10] { 6, 1, 88, 78, 89, 32, 65, 34, 33, 12 };
            int n = 10;
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int temp, smallest;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            Console.WriteLine();
            Console.Write("Sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}