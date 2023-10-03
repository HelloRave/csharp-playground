# csharp-playground

## Datatypes and Variables
**Integral**

`sbyte x = 1;` range from -128 - 127

`short x = 1;` range from -32,768 - 32,767

`integer x = 1;` range from -2,147,483,648 - 2,147,483,647

`long x = 1;` range from –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

**Floating point**

`float x = 0.5f;`  7-digit precision

`double x = 0.5;` 15-digit precision

`decimal x = 0.5m;` 28-digit precision

**Boolean**

`bool isTrue = true;`

**Unicode characters and strings**

`char c = ‘A’;`

`string name = “John Doe”;`

**Constants**

## Value vs Reference Types

## Implicit, Explicit, Type Conversion
**Implicitly-typed local variables**
```
var greeting = "Hello";
Console.WriteLine(greeting.GetType());  // output: System.String

var a = 32;
Console.WriteLine(a.GetType());  // output: System.Int32

var xs = new List<double>();
Console.WriteLine(xs.GetType());  // output: System.Collections.Generic.List`1[System.Double]
```

## String concatenation, formatting and special characters

## String methods
- `SubString(int32)`
- `ToLower()`
- `ToUpper()`
- `Trim()`
- `IndexOf(string)`
- `String.IsNullOrWhiteSpace()`
- `String.Format("Replace index with object: {index}", object)`

## Methods
**Defining methods**
```
<Access Specifier> <Return type> <Method Name> (Parameter list) { Method Body }
```
- Access Specifier/Modifier − This determines the visibility of a variable or a method from another class.
- Return type − A method may return a value. The return type is the data type of the value the method returns. If the method is not returning any values, then the return type is void.
- Method name − Method name is a unique identifier and it is case sensitive. It cannot be same as any other identifier declared in the class.
- Parameter list − Enclosed between parentheses, the parameters are used to pass and receive data from a method. The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.
- Method body − This contains the set of instructions needed to complete the required activity.

**Try/Catch block**

`try { } catch (Exception) { } finally { }`

## References
1. [Using .NET in Visual Studio Code](https://code.visualstudio.com/docs/languages/dotnet)
2. [GitHub’s collection of .gitignore file templates](https://github.com/github/gitignore)
3. [C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
4. [C# Cheatsheet (1)](https://cheatography.com/laurence/cheat-sheets/c/)
5. [C# Cheatsheet (2)](https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf)