System.Console.WriteLine("enter firstinteger");
int firstinteger = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter secondinteger");
int secondinteger = int.Parse(Console.ReadLine());
System.Console.WriteLine("enter thirdinteger");
int thirdinteger = int.Parse(Console.ReadLine());
int bigesst = 0;
if (firstinteger>bigesst)
{
    bigesst = firstinteger;
}
 if (secondinteger>bigesst)
{
    bigesst = secondinteger;
}
 if (thirdinteger>bigesst)
{
    bigesst = thirdinteger;
}
System.Console.WriteLine($"the biggest is {bigesst}");
