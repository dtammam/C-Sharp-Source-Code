/*
The factorial of a number N is equal to 1 * 2 * 3 * ... * N

For example, the factorial of 5 is 1 * 2 * 3 * 4 * 5 = 120.

The given program takes a number from the input.

Task

Create a program to calculate and output the factorial of that input number.

level
Use a for loop to make the calculation, and start the loop from the number 1.
*/
 using System;

public class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        //your code goes here
        for (int i=1; i<=num; i++) {
            result*=i;
        }
        Console.WriteLine(result);
    }
}