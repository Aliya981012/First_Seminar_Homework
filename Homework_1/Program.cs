Console.WriteLine("Input first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int second = Convert.ToInt32(Console.ReadLine());
int max = first;
if(second > max)
{
    Console.WriteLine("max = "+ second);
}
else
{
    Console.WriteLine("max = "+ first);
}
