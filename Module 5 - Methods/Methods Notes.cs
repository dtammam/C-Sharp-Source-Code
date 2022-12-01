/*
💡methods are reusable, we define them once and can call them multiple times

💡the static keyword is used in the definition of a method, so we can call them in Main.

💡The void keyword means that the method does not return a value.

💡In C#, it is good practice to start with an uppercase letter when naming methods

💡To call a method, use its name followed by parentheses.

We will learn about return values in the next lessons, so stay tuned!
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