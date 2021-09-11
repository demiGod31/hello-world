/*Input:
N = 5
Arr[] = {1,2,3,-2,5}
Output:
9
Explanation:
Max subarray sum is 9
of elements (1, 2, 3, -2, 5) which 
is a contiguous subarray.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {

                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                int[] arr2 = Array.ConvertAll(elements.Split(), int.Parse);
                for (int i = 0; i < n; i++)
                {
                    arr[i] = arr2[i];
                }
                Solution obj = new Solution();
                var res = obj.maxSubarraySum(arr, n);
                Console.WriteLine(res);
                
            }

        }
    }

class Solution
{
    // arr: input array
    // n: size of array
    //Function to find the sum of contiguous subarray with maximum sum.
    public long maxSubarraySum(int[] arr, int n)
    {
        long max = arr[0];
        long curr_max = arr[0];
        
        for (int i = 1; i < n ; i++)
        {
            curr_max = Math.Max(arr[i], curr_max + arr[i]);
            max = Math.Max(max, curr_max);
        }
        return max;
    }
    

}
