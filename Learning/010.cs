using System;
class pk{
	public static void Main(){
		Console.WriteLine($"max in 34,67 is : {Math.Max(34,67)}");
		Console.WriteLine($"min in 34,67 is : {Math.Min(34,67)}");
		Console.WriteLine($"Square root of 64 is : {Math.Sqrt(66)}");
		Console.WriteLine($"Absolute value of -8.9 is : {Math.Abs(-8.9)}");

		Console.WriteLine($"Round of 8.3 is : {Math.Round(8.3)}"); // float
		Console.WriteLine($"Round of 8.5 is : {Math.Round(8.5d)}"); // d for Double
		Console.WriteLine($"Round of 8.6 is : {Math.Round(8.6m)}"); // m for Decimal
		Console.WriteLine($"Round of 8.56558494944 upto 2 decimal : {Math.Round(8.56558494944,2)}");

		
	}
}