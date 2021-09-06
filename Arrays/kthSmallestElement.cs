/*Given an array arr[] and an integer K where K is smaller than size of array,
the task is to find the Kth smallest element in the given array.
It is given that all array elements are distinct.
Input: arr[] = {7, 10, 4, 3, 20, 15} 
k = 3 
Output: 7*/

using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
		var k = int.Parse(Console.ReadLine());
		Console.WriteLine(kthSmallest(arr, k));
	}
	
	private static int kthSmallest(int[] arr, int k)
	{
		Array.Sort(arr);
		return arr[k-1];
	}
}