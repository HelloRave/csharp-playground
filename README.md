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

## References
1. [Using .NET in Visual Studio Code](https://code.visualstudio.com/docs/languages/dotnet)
2. [GitHub’s collection of .gitignore file templates](https://github.com/github/gitignore)
3. [C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)