using System;
namespace Delegate{
	public delegate int MyDelegate(int arg1,int arg2);
	class Program{
		public static void Main(string[] args){
			MyDelegate f = delegate(int a1,int a2){
				return a1+a2;
			};
			Console.WriteLine("The number is "+f(10,20));
		}
	}
}