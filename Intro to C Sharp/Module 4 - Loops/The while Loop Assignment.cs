/*
Your math teacher asked you to calculate the sum of the numbers 1 to N, where N is a given number.

The given program takes a number as input.

Task

Write code to output the sum of the numbers from 1 to that number, inclusive.

Input Example⬅️: 10

Output Example➡️: 55
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int start = 1;
        int sum = 0;
        //your code goes here
        while(start!=n+1) {
            sum+=start;
            start++;
        }
        Console.WriteLine(sum);
    }
}