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