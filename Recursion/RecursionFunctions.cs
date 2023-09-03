using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class RecursionFunctions
    {
        public  string ReverseIt(string str)
        {
            if (str.Equals("")) return "";

            return ReverseIt(str.Substring(1)) + str[0];
           

        }

        public bool PalindromeResursion(string str)
        {
            if (str.Length == 0 || str.Length == 1) return true;

            if (str[0] == str[str.Length - 1]) return PalindromeResursion(str.Substring(1,str.Length-2));

            return false;
            

        }

        public string DecimalToBinary(int number,string result)
        {
            if (number == 0) return result;

            result = number % 2 + result;

            return DecimalToBinary(number/2, result);
        }

        public long SumOfN(int num,long sum)
        {
            //directly n=n*(n+1)/2
            if (num == 0) return sum;

            sum = num + sum;

            return SumOfN(num - 1,sum) ;
        }

        public int Sum(int num)
        {
            if (num <= 1) return num;

            return  num + Sum(num - 1);
        }

        public int BinarySearch(int[] arr, int min,int max,int key)
        {
            if (min > max) return -1;
            
            int mid = (min + max) / 2;

            if(key == arr[mid]) return mid;

            if (mid > key) return BinarySearch(arr,min,mid-1,key);

            return BinarySearch(arr, mid + 1, max, key);

        }

        public int Factorial(int num)
        {
            if (num == 1) return num;

            return num * Factorial(num-1);
        }
    }
}
