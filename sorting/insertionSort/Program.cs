using System;

namespace InsertionSortExample
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = {12, 11, 13, 5, 6};
			int n = arr.Length;

			Console.WriteLine("Original Array:");
			PrintArray(arr);

			InsertionSort(arr);

			Console.WriteLine("\nSorted Array:");
			PrintArray(arr);

		}

		static void InsertionSort(int[] arr)
		{
			int n = arr.Length;
			for(int i = 1; i < n; i++)
			{
				int key = arr[i];
				int j = i - 1;

				while ( j>=0 && arr[j] > key)
				{
					arr[j + 1] = arr[j];
					j = j - 1;
				}
				arr[j+1] = key;
			}
		}

		static void PrintArray(int[] arr)
		{
			foreach (var item in arr)
			{
				Console.Write(item + " " );
			}
			Console.WriteLine();
		}
	}
}
