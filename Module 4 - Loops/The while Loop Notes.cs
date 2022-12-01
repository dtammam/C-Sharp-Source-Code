/*
💡the while loop runs as long as the condition is true

💡make sure your condition eventually becomes false, otherwise, you will have an infinite loop.

    int x = 5;

    while(x>0)
    {
        Console.WriteLine(x);
        x--;
    }

💡the do while loop executes the code block once, before checking if the condition is true, and then it repeats the loop as long as the condition is true

    int i = 5;

    do
    {
        Console.WriteLine(i);
        i++;
    } while (i < 5);



Both for and while can be used to accomplish the same task.

The for loop is usually used when the number of times we need to run the loop is known.

The while loop is used when the condition of the loop is more complex and the number of times it runs is based on the expression in the loop. 

level
Use for loops when possible, as it has a cleaner syntax and is easier to read and understand.
*/