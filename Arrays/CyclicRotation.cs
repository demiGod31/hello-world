/*Program to cyclically rotate an array by one
Input:  arr[] = {1, 2, 3, 4, 5}
Output: arr[] = {5, 1, 2, 3, 4}*/

using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
		cyclicRotation(arr);
	}
	
	private static void cyclicRotation(int[] arr)
	{
		var output = new int[arr.Length];
		for(int i=0; i<arr.Length; i++)
		{
			if(i == arr.Length-1)
			{
				output[0]=arr[i];
			}
			else
			{
				output[i+1] = arr[i];
			}
		}
		Console.WriteLine(string.Join(",",output));
	}
}
