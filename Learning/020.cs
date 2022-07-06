using System;
class PK{
	public static void Main(){
		try{
			Console.Write("Enter a Number: ");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter another Number: ");
			int num2 = Convert.ToInt32(Console.ReadLine());
			double res = ((num1*1.0)/num2);
			Console.WriteLine($"the division of num1/num2 is {Math.Round(res,2)}");
		}
		catch(DivideByZeroException e){
			Console.WriteLine(e.Message);
		}
		catch(FormatException e){
			Console.WriteLine(e.Message);
		}
		finally{
			Console.WriteLine("process completed...");
		}
	}
}