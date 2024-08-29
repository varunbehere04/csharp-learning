Console.WriteLine("Addtion Calculator");
int iValue1 = 0;
int iValue2 = 0;

Console.WriteLine("Enter the first number: ");
string userInput = Console.ReadLine();
iValue1 = int.Parse (userInput);

Console.WriteLine("Enter the second number: ");
userInput = Console.ReadLine();
iValue2 = int.Parse (userInput);

int iSum = iValue1 + iValue2;
Console.WriteLine("The sum of "+ iValue1 + " and " + iValue2 + " is : " + iSum);
