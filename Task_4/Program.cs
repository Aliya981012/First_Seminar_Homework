Console.WriteLine("Input first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number");
int third = Convert.ToInt32(Console.ReadLine());
int max = first;
if(max < second)
{
    max = second;
}
if(max < third)
{
    max = third;
}
Console.WriteLine(max);
