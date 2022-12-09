/*
We have a method that outputs Welcome, user! as it is called.


Task

We want to make it more personalized, so redesign the given method so that it will take the given input as the name of the user and output the welcome message with it.

Input Example⬅️: Tommy

Output Example➡️: Welcome, Tommy!
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        //call the method
        Welcome();
    }

    static void Welcome()
    {
        //redesign the method
        string user = Console.ReadLine();
        Console.WriteLine($"Welcome, {user}!");
    }
}