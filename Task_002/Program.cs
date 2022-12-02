Console.Write("a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("b: ");
int b = int.Parse(Console.ReadLine());
if(Math.Pow(b,2) == a)
{
    Console.WriteLine("a квадрат b");
}
else
{
   Console.WriteLine("a не квадрат b"); 
}