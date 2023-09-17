using System;

namespace QuickSortExample
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = GenerateRandomArray(10);

			int n = arr.Length;

			Console.WriteLine("Original Array:");
			PrintArray(arr);

			QuickSort(arr, 0, n - 1);

			Console.WriteLine("\nSorted Array:");
			PrintArray(arr);
		}
		
		static void QuickSort(int[] arr, int low, int high)
		{
			if(low < high)
			{
				int partitionIndex = Partition(arr,low,high);

				QuickSort(arr,low,partitionIndex-1);
				QuickSort(arr, partitionIndex + 1, high);
			}
		}

		static int Partition(int[] arr, int low, int high)
		{
			int pivot = arr[high];
			int i = low -1;

			for(int j = low; j<=high -1; j++)
			{
				if(arr[j] < pivot)
				{
					i++;

					int temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;
				}
			}

			int temp1 = arr[i+1];
			arr[i+1] = arr[high];
			arr[high] = temp1;

			return i + 1;
		}
		static void PrintArray(int[] arr)
		{
			foreach(var item in arr)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
		static int[] GenerateRandomArray(int length)
		{
			Random random = new Random();
			int[] arr = new int[length];

			for(int i = 0; i < length; i++)
			{
				arr[i] = random.Next(1,100);
			}
			return arr;
		}
	}
}
		
