using System;
class pk{
	enum Level{
		low,
		medium,
		high
	}
	public static void Main(){
		Level i =  Level.medium;
		switch(i){
			case Level.low : Console.WriteLine("Low Level");
							 break;
			case Level.medium : Console.WriteLine("Medium Level");
							 break;
			case Level.high : Console.WriteLine("High Level");
							 break;
		}
	}
}