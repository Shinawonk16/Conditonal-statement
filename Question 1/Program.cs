System.Console.WriteLine("enter first num");
int firstnum = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter second num");
int secondnum = int.Parse(Console.ReadLine());
if (firstnum > secondnum)
{
    int num = firstnum;
    firstnum = secondnum;
    secondnum = num;
    System.Console.WriteLine($"firstnum is {firstnum}");
    System.Console.WriteLine($"secondnum is {secondnum}");
}
else
{
    System.Console.WriteLine($"firstnum is {firstnum}");
    System.Console.WriteLine($"secondnum is {secondnum}");
}
