// See https://aka.ms/new-console-template for more information
using Recursion;

Console.WriteLine("Hello, World!");

RecursionFunctions obj = new RecursionFunctions();

string str2 = obj.ReverseIt("hello");

Console.WriteLine(str2);

Console.WriteLine(obj.PalindromeResursion("nayan"));

Console.WriteLine(obj.DecimalToBinary(10, ""));

Console.WriteLine($"Sum of 5 natural number is{ obj.Sum(5)}");

long s = obj.SumOfN(10,0);

Console.WriteLine(s);

int[] arr = { 1, 2 ,3,4,5,6,7,8,9,10};
int target = 10;
Console.WriteLine($"The index of target is {  obj.BinarySearch(arr,0,arr.Length,target)}");

Console.WriteLine($"The factorial of 5  is {obj.Factorial(5)}");
