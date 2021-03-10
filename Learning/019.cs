using System;
class pk{
	static void m1_out(ref int yu){
		yu*=2;
	}
	public static void Main(){
		int x =34;
		
		m1_out(ref x);
		Console.WriteLine($"after method calling x is {x}");
	}
}