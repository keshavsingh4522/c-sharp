using System;
class pk{
	static void m1_out(out int yu){
		yu = 67;
		yu*=2;
	}
	static void area(out int length,out int width,out int parea){
		length=20;
		width=30;
		parea= length*width;
	}
	public static void Main(){
		// 1. With initilizing
		int x;
		// int x = 34; --> it generate error, in out we cant initilize before passing
		m1_out(out x);
		Console.WriteLine($"after method calling x is {x}");


		//2. without initlizing
		area(out int length,out int width,out int parea);
		Console.WriteLine($"length of rectangle :  {length}");
		Console.WriteLine($"width of rectangle :  {width}");
		Console.WriteLine($"area of rectangle :  {parea}");
	}
}