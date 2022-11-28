/*
You want to withdraw some money from your bank account.

The given program declares balance and withdraw variables and assigns them values.

Task

Calculate and output the remaining balance after the withdrawal.
 */

using System;

public class Program
{
    static void Main(string[] args)
    {
        int balance = 416500;
        int withdraw = 160000;

        //your code goes here
        Console.WriteLine(balance-=withdraw);
    }
}