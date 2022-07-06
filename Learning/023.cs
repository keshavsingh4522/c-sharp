using System;
namespace Learning{
	class Book{
		public string title;
		public string author;
		public int pages;
		public void Display(){
			Console.WriteLine($"title of bbok: {title}");
			Console.WriteLine($"author of bbok: {author}");
			Console.WriteLine($"pages in bbok: {pages}\n");
		}
	}
}