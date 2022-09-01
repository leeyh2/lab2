// See https://aka.ms/new-console-template for more information
using System;
using ConsoleTables;
//1. 


Console.WriteLine("Add first number to add ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add 2nd number ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {firstNum} + {secondNum} = {firstNum + secondNum}");


//2

Console.WriteLine("Add a number to multiply");
int firstMultiNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add a the max you want to multiply");
int maxMultiNum = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= maxMultiNum; i++)
{
    Console.WriteLine($"{firstNum} * {i} = {firstNum * i}");
}

//3
ConsoleTable table = new ConsoleTable("Type ", "Byte(s) of memory " , "MIN " ,
       "MAX ");
table.AddRow($"sbyte", sizeof(sbyte), SByte.MinValue, SByte.MaxValue );
table.AddRow($"byte", sizeof(byte), Byte.MinValue, Byte.MaxValue);
table.AddRow($"short", sizeof(short), short.MinValue, short.MaxValue);
table.AddRow($"ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
table.AddRow($"int", sizeof(int), int.MinValue, int.MaxValue);
table.AddRow($"uint", sizeof(uint), uint.MinValue, uint.MaxValue);
table.AddRow($"long", sizeof(long), long.MinValue, long.MaxValue);
table.AddRow($"ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);
table.AddRow($"float", sizeof(float), float.MinValue, float.MaxValue);
table.AddRow($"double", sizeof(double), double.MinValue, double.MaxValue);
table.AddRow($"decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
Console.WriteLine(table);

//4
bool flag = true;
double result = 0;
while (flag)
{
    
    Console.WriteLine("Type first number");
    double firstCalcNum = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Type operator: + , - , * ,/ , %");
    string op = Console.ReadLine();
    Console.WriteLine("Type second number");
    double secondCalcNum = Convert.ToDouble(Console.ReadLine());
    if (op == "+")
    {
        Console.WriteLine($"{firstCalcNum} + {secondCalcNum} = {firstCalcNum + secondCalcNum}");
        result = firstCalcNum + secondCalcNum;
    }
    else if (op == "-")
    {
        Console.WriteLine($"{firstCalcNum} - {secondCalcNum} = {firstCalcNum - secondCalcNum}");
        result = firstCalcNum - secondCalcNum ;
    }
    else if (op == "*")
    {
        Console.WriteLine($"{firstCalcNum} * {secondCalcNum} = {firstCalcNum * secondCalcNum}");
        result = firstCalcNum * secondCalcNum ;
    }
    else if (op == "/")
    {
        Console.WriteLine($"{firstCalcNum} / {secondCalcNum} = {firstCalcNum / secondCalcNum}");
        result = firstCalcNum / secondCalcNum ;
    }
    else if (op == "%")
    {
        Console.WriteLine($"{firstCalcNum} % {secondCalcNum} = {firstCalcNum % secondCalcNum}");
        result = firstCalcNum % secondCalcNum;
    }
    else
    {
        Console.Write("You didn't do it right...");
    }
    
   
    Console.WriteLine("Would you like to continue type hit enter or type \"esc\"");
   string userInput = Console.ReadLine();
    if(userInput=="esc")
    {
        flag = false;
    }
    Console.WriteLine("Type operator: + , - , * ,/ , %");
    string op2 = Console.ReadLine();
    Console.WriteLine("Type  number");
    double thirdCalcNum = Convert.ToDouble(Console.ReadLine());
    if (op2 == "+")
    {
       
        Console.WriteLine($"{result} + {thirdCalcNum} = {result + thirdCalcNum}");
        
    }
    else if (op2 == "-")
    {
        
        Console.WriteLine($"{result} - {thirdCalcNum} = {result - thirdCalcNum}");
    }
    else if (op2 == "*")
    {
        Console.WriteLine($"{result} * {thirdCalcNum} = {result * thirdCalcNum}");
    }

    else if (op2 == "/")
    {
    Console.WriteLine($"{result} / {thirdCalcNum} = {result / thirdCalcNum}");

    }
    else if (op2 == "%")
    {
        Console.WriteLine($"{result} % {thirdCalcNum} = {result % thirdCalcNum}");
    }

    else
    {
        Console.Write("You didn't do it right...");
    }
    flag = false;
}
