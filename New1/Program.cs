// See https://aka.ms/new-console-template for more information
Console.Write("Enter your score : ");
var myScore = Console.ReadLine();
var numScore = int.Parse(myScore);

if (numScore > 100)
{
    Console.WriteLine("Your Garde : Invaild");
}
else if (numScore >= 80)
{
    Console.WriteLine("Your Garde : A");
}
else if (numScore >= 70)
{
    Console.WriteLine("Your Garde : B");
}
else if (numScore >= 60)
{
    Console.WriteLine("Your Garde : C");
}
else if (numScore >= 50)
{
    Console.WriteLine("Your Garde : D");
}
else if (numScore < 0)
{
    Console.WriteLine("Your Garde : Invaild");
}
else
{
    Console.WriteLine("Your Garde : F");
}

