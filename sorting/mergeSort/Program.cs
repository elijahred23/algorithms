using System;

class Program
{
	static void Main()
	{
		int[] arr = {64, 25, 12, 22, 11};

		Console.WriteLine("Unsorted Array:");
		PrintArray(arr);

		MergeSort(arr, 0 , arr.Length - 1);

		Console.WriteLine("\nSorted Array:");

		PrintArray(arr);

	}

	static void MergeSort(int[] arr, int left, int right)
	{
		if(left<right)
		{
			int middle = (left + right) / 2;

			MergeSort(arr, left, middle);
			MergeSort(arr, middle+1, right);

			Merge(arr,left, middle, right);

		}
	}

	static void Merge(int[] arr, int left, int middle, int right)
	{
		int n1 = middle - left + 1;
		int n2 = right - middle;

		int[] leftArray = new int[n1];
		int[] rightArray = new int[n2];

		for(int l = 0; l < n1; l++)
		{
			leftArray[l] = arr[left + l];
		}
		for(int l = 0; l < n2; l++)
		{
			rightArray[l] = arr[middle + 1+ l];
		}

		int k = left;
		int j = 0;
		int i = 0;

		while(i < n1 && j < n2)
		{
			if(leftArray[i] <= rightArray[j])
			{
				arr[k] = leftArray[i];
				i++;
			}
			else
			{
				arr[k] = rightArray[j];
				j++;
			}
			k++;
		}

		while(i < n1)
		{
			arr[k] = leftArray[i];
			i++;
			k++;
		}

		while(j < n2)
		{
			arr[k] = rightArray[j];
			j++;
			k++;
		}
	}
	static void PrintArray(int[] arr)
	{
		foreach(int num in arr)
		{
			Console.Write(num + " " );
		}
		Console.WriteLine();
	}
}

