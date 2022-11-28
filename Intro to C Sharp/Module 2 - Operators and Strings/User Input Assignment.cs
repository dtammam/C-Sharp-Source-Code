/*
You are making a program for a chess tournament that needs to calculate the points earned by a player.

A win is worth 1 point, while a tie is worth 0.5 points.

The given program declares two variables: wins and ties.

Task

Create a program to take the values for wins and ties as input, then calculate and output the points earned by the player.

Hint

Multiply the ties value by 0.5, to get the points earned for ties.
 */

 using System;

public class Program
{
    static void Main(string[] args)
    {
        int wins;
        int ties;

        //taking input and assigning to our variables
        wins = Convert.ToInt32(Console.ReadLine());
        ties = Convert.ToInt32(Console.ReadLine());

        //calculating the score of the player
        Console.WriteLine(wins + ties*0.5);
    }
}