/*Write a program to reverse an array or string
Input  : arr[] = {1, 2, 3}
Output : arr[] = {3, 2, 1}

Input :  arr[] = {4, 5, 1, 2}
Output : arr[] = {2, 1, 5, 4}*/

using System;
using System.Linq;

namespace ReverseArray
{
    public class Program
    {
        public static void Main (String[] args)
        {
            var input = Console.ReadLine();
			var arr = input.Split(',').Select(int.Parse).ToArray();
			Console.WriteLine(String.Join(",",ReverseArray(arr)));
        }
		
		private static int[] ReverseArray(int[] arr)
		{
			var output = new int[arr.Length];
			var k = 0;
			for(int i = arr.Length-1; i>=0; i--)
			{
				output[k]=arr[i];
				k++;
			}
			return output;
		}
    }
}