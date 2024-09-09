string newString  = "Hello World";
int iNum1 = 123;
int iNum2 = 321;

// String Concatenation
Console.WriteLine("NewString : " + newString + " Number 1 : " + iNum1);

// String Interpolation -- This is preferred way in C# 6.0+
Console.WriteLine($"NewString : {newString} Number 1 : {iNum1}");

// String Formatting
Console.WriteLine("NewString : {0} Number 1 : {1}", newString, iNum1);


// Writing using special characters to print =>  This is "string" !
// Console.WriteLine ("This is "string " !");   -- This will throw error
Console.WriteLine ("This is \"string\" !");   //-- This will print the desired output

Console.WriteLine("This is string with \nspecial characters \\ a");