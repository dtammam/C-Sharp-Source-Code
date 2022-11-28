/*
Ever wondered how many seconds are there in a month (30 days) 🕰️?

Let's calculate it! 

Task

Write a program to calculate and output the answer.

Hint

Remember, there are 24 hours in a day, 60 minutes in an hour, and 60 seconds in a minute.
 */

 using System;

public class Program
{
    static void Main(string[] args)
    {
        /* 30 days
        1 day = 24 hours
        1 hour = 60 minutes
        1 minute = 60 seconds */
        
       Console.WriteLine (30*24*60*60);
    }
}