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

## Operators
**Arithmetic Operator**

| Operator | Description |
| -- | -- |
| + | Add numbers |
| - | Subtract numbers |
| * | Multiply numbers |
| / | Divide numbers |
| % | Divide two numbers and returns reminder |

**Increment/Decrement Operator**
- Pre-increment `(++i)` and Post-increment `(i++)`
	- Pre-increment, first it increments by 1 then loop executes
	- Post-increment, the loop executes then it increments by 1
- Pre-Decrement `(--i)` and Post Decrement `(i--)`
	- Pre-decrement the value is decremented by one then loop executes
	- Post-decrement the loop executed then the value decrements by one

**Comparison Operator**

| Operator | Description |
| -- | -- |
| < | Less than |
| > | Greater than |
| < = | Less than equal to |
| >= | Greater than equal to |

**Equality Operator**

| Operator | Description |
| -- | -- |
| == | Equality |
| != | Inequality |

**Boolean Logical Operator**

| Operator | Description |
| -- | -- |
| ! | logical negation of its operand |
| & | evaluates both operands even if the left-hand operand evaluates to false |
| `|` | evaluates both operands even if the left-hand operand evaluates to true |
| ^ | returns false if both/all the expression returns true/false (eg. `false ^ false`, `true ^ true`) |
| && | short-circuiting: doesn't evaluate the right-hand operand if the left-hand operand evaluates to false |
| `||` | short-circuiting: doesn't evaluate the right-hand operand if the left-hand operand evaluates to true |

## Selection statements - `if`, `if-else`, and `switch`

**Default**

`if(<condition>) { } else if (<condition>) { } else { }`

**Ternary Conditional Operator**

`condition ? consequent : alternative`

## Iteration Statements

**`for`**

- Executes a statement or a block of statements while a specified Boolean expression evaluates to true
- Components:
	- Initializer: `int i = 0` - executed only once
	- Condition: `i < 3`
	- Iterator: `i++` - can contain zero or more of the following statement expressions, separated by commas
		- pre/post increment/decrement
		- assignment
		- invocation of a method
		- await expression
		- creation of an object by using the new operator
	- Body

```
for (int i = 0; i < 3; i++)
{
    Console.Write(i);
}

// Output:
// 012
```

```
int i;
int j = 3;
for (i = 0, Console.WriteLine($"Start: i={i}, j={j}"); i < j; i++, j--, Console.WriteLine($"Step: i={i}, j={j}"))
{
    //...
}

// Output:
// Start: i=0, j=3
// Step: i=1, j=2
// Step: i=2, j=1
```

**`foreach`**

```
var fibNumbers = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13 };
foreach (int element in fibNumbers)
{
    Console.Write($"{element} ");
}
// Output:
// 0 1 1 2 3 5 8 13
```

**`do`**

- Expression is evaluated **after** each execution of the loop, a do loop executes one or more times
- Differs from the while loop, which executes zero or more times

```
int n = 0;
do
{
    Console.Write(n);
    n++;
} while (n < 5);

// Output:
// 01234
```

**`while`**

- Expression is evaluated **before** each execution of the loop

```
int n = 0;
while (n < 5)
{
    Console.Write(n);
    n++;
}
// Output:
// 01234
```

## Jump statemets - `break`, `continue`, `return`, `goto`

`break`

- Terminates the closest enclosing iteration statement and transfers control to the statement that follows the terminated statement

```
for (int outer = 0; outer < 5; outer++)
{
    for (int inner = 0; inner < 5; inner++)
    {
        if (inner > outer)
        {
            break;
        }

        Console.Write($"{inner} ");
    }
    Console.WriteLine();
}
// Output:
// 0
// 0 1
// 0 1 2
// 0 1 2 3
// 0 1 2 3 4
```

`continue`

- Starts a new iteration of the closest enclosing iteration statement

```
for (int i = 0; i < 5; i++)
{
    Console.Write($"Iteration {i}: ");
    
    if (i < 3)
    {
        Console.WriteLine("skip");
        continue;
    }
    
    Console.WriteLine("done");
}
// Output:
// Iteration 0: skip
// Iteration 1: skip
// Iteration 2: skip
// Iteration 3: done
// Iteration 4: done
```

`return`

- Terminates execution of the function in which it appears and returns control and the function's result, if any, to the caller

```
Console.WriteLine("First call:");
DisplayIfNecessary(6);

Console.WriteLine("Second call:");
DisplayIfNecessary(5);

void DisplayIfNecessary(int number)
{
    if (number % 2 == 0)
    {
        return;
    }

    Console.WriteLine(number);
}
// Output:
// First call:
// Second call:
// 5
```

## Class

**Inheritance**

## Arrays
**Single Dimensional Array**

**Multi Dimensional Array**

**Jagged Array**

## Collections
**Indexable Collections**

**Key/value pair Collections | Dictionary**

**Stack**

**Queue**

**Hashtable**

## References
1. [Using .NET in Visual Studio Code](https://code.visualstudio.com/docs/languages/dotnet)
2. [GitHub’s collection of .gitignore file templates](https://github.com/github/gitignore)
3. [C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
4. [C# Cheatsheet (1)](https://cheatography.com/laurence/cheat-sheets/c/)
5. [C# Cheatsheet (2)](https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf)