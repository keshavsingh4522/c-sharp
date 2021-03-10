using System;
class pk{
	static void display(string[] s){
		foreach(string i in s){
			Console.WriteLine(i);
		}
	}
	public static void Main(){
		// create and intilize array
		string[] s = {"keshav","siranam","shakuntala","ramprasad","pradeep","gulkando"};
		display(s);

		Console.WriteLine("\nafter sorting");
		// sort
		Array.Sort(s);
		display(s);

		Console.WriteLine("\nafter Reversing");
		// reverse array
		Array.Reverse(s);
		display(s);
	}
}