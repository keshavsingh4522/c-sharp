using System;
using Learning.Book;
namespace Learning{
	class Program{
		public static void Main(){
			Book book1 = new Book();
			book1.title="haripotter";
			book1.author="idontknow";
			book1.pages=200;

			Book book2 = new Book();
			book2.title="PK";
			book2.author="Keshav Singh";
			book2.pages=347;

			book1.Display();
			book2.Display();
		}
	}
}