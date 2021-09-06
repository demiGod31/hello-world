/*Maximum and minimum of an array using minimum number of comparisons
{1000, 11, 445, 1, 330, 3000};
Minimum element is 1
Maximum element is 3000*/

using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var input = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
		MaxMinOfArray(input);
	}
	
	private static void MaxMinOfArray(int[] input)
	{
		int max = input[0];
		int min = input[0];
		foreach(var arr in input)
		{
			if(arr > max)
			{
				max = arr;
			}
			if(arr < min)
			{
				min = arr;
			}
		}
		Console.WriteLine("Minimum element is " + min);
		Console.WriteLine("Maximum element is " + max);
	}
}