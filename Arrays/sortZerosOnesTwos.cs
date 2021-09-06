/*Given an array of size N containing only 0s, 1s, and 2s; sort the array in ascending order.
Input: 
N = 5
arr[]= {0,2,1,2,0}
Output:
0,0,1,2,2
Explanation:
0s 1s and 2s are segregated 
into ascending order.*/

using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
		Console.WriteLine(String.Join(",",SortZerosOnesTwos(arr)));
	}
	
	private static int[] SortZerosOnesTwos(int[] arr)
	{
		var output = new int[arr.Length];
		var zeros = 0;
		var ones = 0;
		var twos = 0;
		
		foreach(var ar in arr)
		{
			if(ar == 0)
				zeros++;
			if(ar == 1)
				ones++;
			if(ar == 2)
				twos++;
		}
		for (int i = 0; i < arr.Length; i++)
		{
			if(zeros != 0)
			{
				output[i] = 0;
				zeros--;
				continue;
			}
			else if(ones != 0)
			{
				output[i] = 1;
				ones--;
				continue;
			}
			else
			{
				output[i] = 2;
				twos--;
			}
		}
		return output;
	}
}