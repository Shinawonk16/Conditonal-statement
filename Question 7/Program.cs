System.Console.WriteLine("enter num1");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter num2");
int num2 = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter num3");
int num3 = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter num4");
int num4 = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter num5");
int num5 = int.Parse(Console.ReadLine());
int greatest = 0;
if (num1 > greatest)
{
    greatest = num1;
}
 if (num2 > greatest)
{
    greatest = num2;
}
if (num3 > greatest)
{
    greatest = num3;
}
if (num4 > greatest)
{
    greatest = num4;
}

if (num5 > greatest)
{
    greatest = num5;
}
System.Console.WriteLine($"the greatest num is {greatest}");