/*Given two sorted arrays, find their union and intersection.
Input : arr1[] = {1, 3, 4, 5, 7}
        arr2[] = {2, 3, 5, 6} 
Output : Union : {1, 2, 3, 4, 5, 6, 7} 
         Intersection : {3, 5}*/

using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		var arr1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
		var arr2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
		UnionAndIntersection(arr1, arr2);
	}
	
	private static void UnionAndIntersection(int[] arr1,int[] arr2)
	{
		var count = new Dictionary<int,int>();
		
		foreach(var num in arr1)
		{
			if(count.ContainsKey(num))
			{
				count[num] += 1;
			}
			else
			{
				count.Add(num, 0);
			}
		}
		foreach(var num in arr2)
		{
			if(count.ContainsKey(num))
			{
				count[num] += 1;
			}
			else
			{
				count.Add(num, 0);
			}
		}
		var union = count.Keys.ToArray();
		var intersection = count.Where(w => w.Value > 0).Select(s => s.Key).ToArray();
		Console.WriteLine("Union : " + string.Join(",",union));
		Console.WriteLine("Intersection : " + string.Join(",",intersection));
	}
}
