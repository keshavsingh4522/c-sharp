using System;
class pk{
	public static void Main(){
		string fname = "Keshav";
		string lname = "Singh";

		// length
		Console.WriteLine($"the length of string fname is {fname.Length}");
		
		//concatination
		string fullname = fname+" "+lname;
		Console.WriteLine($"full name is {fullname}");
		Console.WriteLine($"full name is {fname} {lname}"); // String Interpolation
		Console.WriteLine($"full name is {string.Concat(fname," ",lname)}");
		
		// upper/lower case
		Console.WriteLine($"fullname in upper Case : {fullname.ToUpper()}");
		Console.WriteLine($"fullname in lower Case : {fullname.ToLower()}");

		//Access Strings
		Console.WriteLine($"first char in first name is {fname[0]}");
		// indexof
		Console.WriteLine($"index of s in fullname: {fullname.IndexOf("s")}");
		Console.WriteLine($"index of S in fullname: {fullname.IndexOf("S")}");
		Console.WriteLine($"index of h in fullname: {fullname.IndexOf("h")}");
		Console.WriteLine($"index of h in fullname: {fullname.IndexOf("h",4)}");

		// substring --> used with indexof
		int pos = fullname.IndexOf("S");
		Console.WriteLine($"last name from full name is {fullname.Substring(pos)}");

		// backslash
		Console.WriteLine("my name is \"Keshav Singh\"");
		Console.WriteLine($"10+20 : {10+20}");
		Console.WriteLine($"10+\"20\" : {10+"20"}");
		Console.WriteLine($"\"10\"+20 : {"10"+20}");


	}
}