/*
We need to calculate the area of a given rectangle.

The given program takes the width and length as input.

Task

Fix and complete the Area method, which takes the length and width as arguments, to calculate and return the area.

Then call the method for the given inputs.

Example Input

7
4

Example Output
28


To find the area of a rectangle, multiply the length by the width.
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        int width = Convert.ToInt32(Console.ReadLine());
        int length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Area(width,length));
        
    }


    //fix the method
    static int Area(int x, int y)
    {
        return x*y;        
    }
}