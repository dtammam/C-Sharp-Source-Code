/* 
You need to make a function that converts a foot value to inches.

1 foot has 12 inches.

The given code takes the foot value as input and passes it to the Converter method.

Task

Define a Converter method that takes the foot value as an argument and outputs the inches value.
*/

 using System;

public class Program
{
    static void Main(string[] args)
    {
        double foot = Convert.ToDouble(Console.ReadLine());
        Converter(foot);
    }

    //your code goes here
    static void Converter(double foot)
    {
        if(foot>0) {
            foot*=12;
            Console.WriteLine(foot);
        }

        else {
            Console.WriteLine("Invalid");
        }

    }
}