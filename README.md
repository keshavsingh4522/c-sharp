# c-sharp
- install on ubuntu
```bash
sudo apt install mono-complete
```
- compile .cs file
```bash
# method 1
mcs hello.cs # this create .exe file with same name as .cs file name as hello.exe

# method 2
mcs -out:output.exe hello.cs
```
- run .exe file
```bash
# method 1
mono hello.exe
# method 2
./hello.exe
```
- data types and variable [(___001.cs___)](https://www.w3schools.com/cs/cs_data_types.asp)
```c#
/*

    int - stores integers (whole numbers), without decimals, such as 123 or -123
    double - stores floating point numbers, with decimals, such as 19.99 or -19.99
    char -Char values are surrounded by single quotes
    string - String values are surrounded by double quotes
    bool - true or false
    const

*/
//for example
// lets store a string in varible using var keyword
int num = 1500;
long myNum = 15000000000L;

// float upto 6 or 7 decimal point
// double upto 15 decimal points
float f1 = 35e-3F;
double d1 = 12E4D;

bool isCSharpFun = true;
bool isFishTasty = false;

char myGrade = 'B';

var anything = "hello user, whats up";
// display varibale 
System.Console.WriteLine(anything);
```
**Note:-** "e" to indicate the power of 10

- take input from user(___002.cs___)
```c#
// take input
var x = System.Console.ReadLine();
// display input
System.Console.WriteLine(x);
```
- before console we use System so lets remove by importing as(___003.cs___)
```c#
using System;
Console.WriteLine("hi how are you")
```
- WriteLine display outoupt in new line while Write display in same line(___004.cs___)
```c#
Console.WriteLine("Hello World!");  
Console.WriteLine("I will print on a new line.");

Console.Write("Hello World! ");
Console.Write("I will print on the same line.");
```
- Comments
```c#
// single line comments

/*
multi
line
comments
*/
```
- [Type Casting](https://www.w3schools.com/cs/cs_type_casting.asp)
	- Implicit Casting (automatically) - converting a smaller type to a larger type size
```c#
	char -> int -> long -> float -> double

// ex
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double
```
	- Explicit Casting (manually) - converting a larger type to a smaller size type
```c#
	double -> float -> long -> int -> char
```
- 
	- Type Conversion Methods (___005.cs___)
```c#
/*
It is also possible to convert data types explicitly by using built-in methods, such as*/ 
Convert.ToBoolean, 
Convert.ToDouble, 
Convert.ToString,
Convert.ToInt32 (int) and 
Convert.ToInt64 (long)

// ex
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
```

- [Boxing and and unboxing(___007.cs___)](https://www.tutorialsteacher.com/articles/boxing-unboxing-in-csharp)
![](https://www.tutorialsteacher.com/Content/images/articles/csharp/boxing.PNG)
![](https://www.tutorialsteacher.com/Content/images/articles/csharp/unboxing.PNG)
```C#
// Boxing
int i = 100;
object obj = i;
Console.WriteLine(obj);

//Unboxing
object objc = 2000;
int ij = (int)objc;
Console.WriteLine(ij);
```
- Enum and constant(___008.cs-009.cs___)
```c#
// enum inside class and outide class
// enum 
enum Day{
	sun,
	mon,
	tue,
	wed =67,
	thu,
	fri,
	sat
}
public static void Main(){
	Console.WriteLine(Day.sun);
	Console.WriteLine((int)Day.sun);
	foreach(string name in Enum.GetNames(typeof(Day))){
		Console.WriteLine(name);
	}
	foreach(int value in Enum.GetValues(typeof(Day))){
		Console.WriteLine($"{Enum.GetName(typeof(Day),value)} : {value}");
	}
}

// enum in switch
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
```
- Control Statements
	- C# offers three types of control statements:
    	- Selection Statements – This consists of if, else, switch, and case branching.
    	- Iteration Statements – This consists of do, for, foreach, and while looping.
    	- Jump Statements – This consists of break, continue, return, and goto statements.
- Math.Round()  (___0010.cs___)
```c#
Math.Round(12.45) // 12
Math.Round(12.56d) // 13  --> d is Double
Math.Round(12.5m) // 13  ---> m means Decimal
Math.Round(12.34567,2)  // 12.35  --> round upto 2 decimal points
```
- string(___011.cs___)
- Booleans(___012.cs___)
```c#
//bool keyword used
bool flag_f = false;
bool flag_t = true;

Console.WriteLine(flag_f);
Console.WriteLine(flag_t);
```
-  if, else if,else
```
same as in c
```
- switch case (___013.cs___)
- for loop, while loop, do while loop
```
same as in c
```
- foreach loop(___014.cs___)
- Array(___015.cs-017.cs___)
```C#
// number of ways to create array


// Create an array of four elements, and add values later
string[] cars = new string[4];

// Create an array of four elements and add values right away 
string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements without specifying the size 
string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};

// Create an array of four elements, omitting the new keyword, and without specifying the size
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"}; // this method is faster and easier to read.

// However, you should note that if you declare an array and initialize it later, you have to use the new keyword:

// Declare an array
string[] cars;
// Add values, using new
cars = new string[] {"Volvo", "BMW", "Ford"};
- // Add values without using new (this will cause an error)
- cars = {"Volvo", "BMW", "Ford"};

```
- Ref and Out keywords
	- ref and out both are same at compile time but different at run time
	- ref is bi-directional while out is uni-directional
	- out --> this returns the value of passed parameters only