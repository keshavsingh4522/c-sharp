using System;
class PK{
	public string title;
	public string author;
	public int pages;
	public void Display(){
		Console.WriteLine($"title of bbok: {title}");
		Console.WriteLine($"author of bbok: {author}");
		Console.WriteLine($"pages in bbok: {pages}\n");
	}
	public static void Main(){
		PK book1 = new PK();
		book1.title="haripotter";
		book1.author="idontknow";
		book1.pages=200;

		PK book2 = new PK();
		book2.title="PK";
		book2.author="Keshav Singh";
		book2.pages=347;

		book1.Display();
		book2.Display();
	}
}