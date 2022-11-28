/*
Here is a quick summary:
💡the escape character \ is used to include quotes or special characters in a string

💡you can use \n for a new line, and \t for a tab

💡the verbatim string allows special characters and linebreaks in strings
*/

/*
Assignment:
The given code declares a text variable with a value of "ABCD".

Task

Write a program to output each letter on a separate line, like this 👇:

A
B
C
D
*/

using System;

public class Program
{
    static void Main(string[] args)
    {
        string text = "A\nB\nC\nD";
        Console.WriteLine(text);
    }
}