using System;
class pk{
	enum Day{
		sun,
		mon,
		tue=70,
		wed,
		thu,
		fri,
		sat
	};
	public static void Main(){	
		// Console.WriteLine(Day.sun);
		// Console.WriteLine((int)Day.sun);
		foreach(string name in Enum.GetNames(typeof(Day))){
			Console.WriteLine(name);
		}
		foreach(int value in Enum.GetValues(typeof(Day))){
			Console.WriteLine($"{Enum.GetName(typeof(Day),value)} : {value}");
		}		
	}
}