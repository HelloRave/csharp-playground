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

**Anonymous methods**

**Lambda expression**


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

- The number of dimensions are set when an array variable is declared. The length of each dimension is established when the array instance is created. These values can't be changed during the lifetime of the instance.
- Array types are reference types derived from the abstract base type Array. All arrays implement IList and IEnumerable

**Single Dimensional Array**
```
// Declare a single-dimensional array.
int[] array1 = new int[5];
array1[0] = 20;
array1[1] = 30;
array1[2] = 50;
array1[3] = 50;
array1[4] = 50;

// Declare and set array element values.
int[] array2 = { 1, 2, 3, 4, 5, 6 };
```

**Multi Dimensional Array**
```
// Declare a two dimensional array.
int[,] array2DDeclaration = new int[4, 2];
int[,,] array3DDeclaration = new int[4, 2, 3];

// Declare and set array element values.
int[,] array2DInitialization =  { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4,   5,  6 } },
                                { { 7, 8, 9 }, { 10, 11, 12 } } };

for (int i = 0; i < array3D.GetLength(0); i++)
{
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            System.Console.Write($"{array3D[i, j, k]} ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
// Output (including blank lines): 
// 1 2 3
// 4 5 6
// 
// 7 8 9
// 10 11 12
//
```

**Jagged Array**
- A jagged array is an array of arrays, and each member array has the default value of null
```
// Declare a jagged array.
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
jaggedArray[1] = new int[] { 0, 2, 4, 6 };
jaggedArray[2] = new int[] { 11, 22 };

int[][] jaggedArray2 = 
{
    new int[] { 1, 3, 5, 7, 9 },
    new int[] { 0, 2, 4, 6 },
    new int[] { 11, 22 }
};

// Assign 77 to the second element ([1]) of the first array ([0]):
jaggedArray2[0][1] = 77;

// Assign 88 to the second element ([1]) of the third array ([2]):
jaggedArray2[2][1] = 88;
```

## Collections
**Indexable Collections**
```
// Create a list of strings by using a
// collection initializer.
var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook coho pink sockeye

// Remove an element from the list by specifying
// the object.
salmons.Remove("coho");


// Iterate using the index:
for (var index = 0; index < salmons.Count; index++)
{
    Console.Write(salmons[index] + " ");
}
// Output: chinook pink sockeye

// Add the removed element
salmons.Add("coho");
// Iterate through the list.
foreach (var salmon in salmons)
{
    Console.Write(salmon + " ");
}
// Output: chinook pink sockeye coho
```

**Key/value pair Collections | Dictionary**
```
// Create a new dictionary of strings, with string keys.

Dictionary<string, string> openWith =
    new Dictionary<string, string>();

// Add some elements to the dictionary. There are no
// duplicate keys, but some of the values are duplicates.
openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");

// The Add method throws an exception if the new key is
// already in the dictionary.
try
{
    openWith.Add("txt", "winword.exe");
}
catch (ArgumentException)
{
    Console.WriteLine("An element with Key = \"txt\" already exists.");
}

// The Item property is another name for the indexer, so you
// can omit its name when accessing elements.
Console.WriteLine("For key = \"rtf\", value = {0}.",
    openWith["rtf"]);

// The indexer can be used to change the value associated
// with a key.
openWith["rtf"] = "winword.exe";
Console.WriteLine("For key = \"rtf\", value = {0}.",
    openWith["rtf"]);

// If a key does not exist, setting the indexer for that key
// adds a new key/value pair.
openWith["doc"] = "winword.exe";

// The indexer throws an exception if the requested key is
// not in the dictionary.
try
{
    Console.WriteLine("For key = \"tif\", value = {0}.",
        openWith["tif"]);
}
catch (KeyNotFoundException)
{
    Console.WriteLine("Key = \"tif\" is not found.");
}

// When a program often has to try keys that turn out not to
// be in the dictionary, TryGetValue can be a more efficient
// way to retrieve values.
string value = "";
if (openWith.TryGetValue("tif", out value))
{
    Console.WriteLine("For key = \"tif\", value = {0}.", value);
}
else
{
    Console.WriteLine("Key = \"tif\" is not found.");
}

// ContainsKey can be used to test keys before inserting
// them.
if (!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Value added for key = \"ht\": {0}",
        openWith["ht"]);
}

// When you use foreach to enumerate dictionary elements,
// the elements are retrieved as KeyValuePair objects.
Console.WriteLine();
foreach( KeyValuePair<string, string> kvp in openWith )
{
    Console.WriteLine("Key = {0}, Value = {1}",
        kvp.Key, kvp.Value);
}

// To get the values alone, use the Values property.
Dictionary<string, string>.ValueCollection valueColl =
    openWith.Values;

// The elements of the ValueCollection are strongly typed
// with the type that was specified for dictionary values.
Console.WriteLine();
foreach( string s in valueColl )
{
    Console.WriteLine("Value = {0}", s);
}

// To get the keys alone, use the Keys property.
Dictionary<string, string>.KeyCollection keyColl =
    openWith.Keys;

// The elements of the KeyCollection are strongly typed
// with the type that was specified for dictionary keys.
Console.WriteLine();
foreach( string s in keyColl )
{
    Console.WriteLine("Key = {0}", s);
}

// Use the Remove method to remove a key/value pair.
Console.WriteLine("\nRemove(\"doc\")");
openWith.Remove("doc");

if (!openWith.ContainsKey("doc"))
{
    Console.WriteLine("Key \"doc\" is not found.");
}

/* This code example produces the following output:

An element with Key = "txt" already exists.
For key = "rtf", value = wordpad.exe.
For key = "rtf", value = winword.exe.
Key = "tif" is not found.
Key = "tif" is not found.
Value added for key = "ht": hypertrm.exe

Key = txt, Value = notepad.exe
Key = bmp, Value = paint.exe
Key = dib, Value = paint.exe
Key = rtf, Value = winword.exe
Key = doc, Value = winword.exe
Key = ht, Value = hypertrm.exe

Value = notepad.exe
Value = paint.exe
Value = paint.exe
Value = winword.exe
Value = winword.exe
Value = hypertrm.exe

Key = txt
Key = bmp
Key = dib
Key = rtf
Key = doc
Key = ht

Remove("doc")
Key "doc" is not found.
*/
```

**Stack**

**Queue**

**Hashtable**
```
using System;
using System.Collections;

class Example
{
    public static void Main()
    {
        // Create a new hash table.
        //
        Hashtable openWith = new Hashtable();

        // Add some elements to the hash table. There are no
        // duplicate keys, but some of the values are duplicates.
        openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.exe");
        openWith.Add("dib", "paint.exe");
        openWith.Add("rtf", "wordpad.exe");

        // The Add method throws an exception if the new key is
        // already in the hash table.
        try
        {
            openWith.Add("txt", "winword.exe");
        }
        catch
        {
            Console.WriteLine("An element with Key = \"txt\" already exists.");
        }

        // The Item property is the default property, so you
        // can omit its name when accessing elements.
        Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

        // The default Item property can be used to change the value
        // associated with a key.
        openWith["rtf"] = "winword.exe";
        Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

        // If a key does not exist, setting the default Item property
        // for that key adds a new key/value pair.
        openWith["doc"] = "winword.exe";

        // ContainsKey can be used to test keys before inserting
        // them.
        if (!openWith.ContainsKey("ht"))
        {
            openWith.Add("ht", "hypertrm.exe");
            Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
        }

        // When you use foreach to enumerate hash table elements,
        // the elements are retrieved as KeyValuePair objects.
        Console.WriteLine();
        foreach( DictionaryEntry de in openWith )
        {
            Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
        }

        // To get the values alone, use the Values property.
        ICollection valueColl = openWith.Values;

        // The elements of the ValueCollection are strongly typed
        // with the type that was specified for hash table values.
        Console.WriteLine();
        foreach( string s in valueColl )
        {
            Console.WriteLine("Value = {0}", s);
        }

        // To get the keys alone, use the Keys property.
        ICollection keyColl = openWith.Keys;

        // The elements of the KeyCollection are strongly typed
        // with the type that was specified for hash table keys.
        Console.WriteLine();
        foreach( string s in keyColl )
        {
            Console.WriteLine("Key = {0}", s);
        }

        // Use the Remove method to remove a key/value pair.
        Console.WriteLine("\nRemove(\"doc\")");
        openWith.Remove("doc");

        if (!openWith.ContainsKey("doc"))
        {
            Console.WriteLine("Key \"doc\" is not found.");
        }
    }
}

/* This code example produces the following output:

An element with Key = "txt" already exists.
For key = "rtf", value = wordpad.exe.
For key = "rtf", value = winword.exe.
Value added for key = "ht": hypertrm.exe

Key = dib, Value = paint.exe
Key = txt, Value = notepad.exe
Key = ht, Value = hypertrm.exe
Key = bmp, Value = paint.exe
Key = rtf, Value = winword.exe
Key = doc, Value = winword.exe

Value = paint.exe
Value = notepad.exe
Value = hypertrm.exe
Value = paint.exe
Value = winword.exe
Value = winword.exe

Key = dib
Key = txt
Key = ht
Key = bmp
Key = rtf
Key = doc

Remove("doc")
Key "doc" is not found.
 */
```

## Regex
**CHARACTER ESCAPES**

- `\t` 		- Matches a tab
- `\n`		- Matches a new line

**CHARACTER CLASSES**

- `.`       - Wildcard: Matches any single character except \n.
- `\d`      - Matches any decimal digit. (0-9)
- `\D`      - Matches any character other than a decimal digit. (0-9)
- `\w`      - Word Character (a-z, A-Z, 0-9, _)
- `\W`      - Not a Word Character
- `\s`      - Matches any white-space character. (space, tab, newline)
- `\S`      - Matches any non-white-space character (space, tab, newline)
- `[character_group]`     - Matches any single character in character_group. By default, the match is case-sensitive.
- `[^character_group]`    - Negation: Matches any single character that is not in character_group. By default, characters in character_group are case-sensitive.

**ANCHORS**

- `^`       - The match must start at the beginning of the string or line.
- `$`       - The match must occur at the end of the string or before \n at the end of the line or string.
- `\A`		- The match must occur at the start of the string.
- `\Z` 		- The match must occur at the end of the string or before \n at the end of the string.
- `\b`      - Word Boundary
- `\B`      - Not a Word Boundary

**ALTERNATION CONSTRUCTS**
- `|`       - Either Or

**GROUPING CONSTRUCT**

- `( )`     - Group

**Quantifiers**

- `*`       - Matches the previous element zero or more times.
- `+`       - Matches the previous element one or more times.
- `?`       - Matches the previous element zero or one time.
- `{n}`     - Matches the previous element exactly n times.
- `{n,m}`   - Matches the previous element at least n times, but no more than m times.
- 
**MetaCharacters (Need to be escaped)**

- `.[{()\^$\?*+`

## Delegates

## Misc
**`params` Modifier**

```
public static void UseParams(params int[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

    public static void UseParams2(params object[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }

// You can send a comma-separated list of arguments of the
// specified type.
UseParams(1, 2, 3, 4);
UseParams2(1, 'a', "test");

// A params parameter accepts zero or more arguments.
// The following calling statement displays only a blank line.
UseParams2();

// An array argument can be passed, as long as the array
// type matches the parameter type of the method being called.
int[] myIntArray = { 5, 6, 7, 8, 9 };
UseParams(myIntArray);

object[] myObjArray = { 2, 'b', "test", "again" };
UseParams2(myObjArray);

/*
Output:
    1 2 3 4
    1 a test

    5 6 7 8 9
    2 b test again
*/
```

## References
1. [Using .NET in Visual Studio Code](https://code.visualstudio.com/docs/languages/dotnet)
2. [GitHub’s collection of .gitignore file templates](https://github.com/github/gitignore)
3. [C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
4. [C# Cheatsheet (1)](https://cheatography.com/laurence/cheat-sheets/c/)
5. [C# Cheatsheet (2)](https://www.thecodingguys.net/resources/cs-cheat-sheet.pdf)
