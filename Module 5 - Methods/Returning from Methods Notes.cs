/*
Consider a method from our previous lesson, that was used to output a percentage of the given value:

	static void Perc(double num, int percentage)
	{
		double res = num*percentage/100;
		Console.WriteLine(res);
	}

we can return our result using the return keyword:

	static double Perc(double num, int percentage)
	{
		double res = num*percentage/100;
		return res;
	}

The return keyword stops the method from executing. If there are any statements after, they won't run.

This also means that a method can have only one return keyword.

After we have created our method that returns a value, we can call it in our code and assign the result to a variable:

	double result = Perc(640,24);

	Console.WriteLine($"Result is: {result}");
	C#

Returning is useful when you don't need to print the result of the method, but need to use it in your code. For example, a bank account's Withdraw() method could return the remaining balance of the account.

💡the return statement ends function execution and returns the resulting value

💡you can use that value throughout the program, which is the advantage of the return statement

💡The returned value can be assigned to a variable when calling the method.
*/