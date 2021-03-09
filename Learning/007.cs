using System;
class pk{
	public static void Main(){
		// Boxing
		int i = 100;
		object obj = i;
		Console.WriteLine(obj);

		//Unboxing
		object objc = 2000;
		int ij = (int)objc;
		Console.WriteLine(ij);
	}
}