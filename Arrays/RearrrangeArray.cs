/*Move all negative numbers to beginning and positive to end with constant extra space
Input: -12, 11, -13, -5, 6, -7, 5, -3, -6
Output: -12 -13 -5 -7 -3 -6 11 6 5
Note: Order of elements is not important here.*/
using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
		rearrange(arr);
	}
	
	private static void rearrange(int[] arr)
	{
		var start = 0;
		var end = arr.Length - 1;
		var output = new int[arr.Length];
		
		foreach(var num in arr)
		{
			if(num < 0)
			{
				output[start] = num;
				start++;
			}
			else
			{
				output[end] = num;
				end--;
			}
		}
		Console.WriteLine(string.Join(",",output));
	}
}
