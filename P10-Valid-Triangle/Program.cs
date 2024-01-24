int sideA = int.Parse(Console.ReadLine());
int sideB = int.Parse(Console.ReadLine());
int sideC = int.Parse(Console.ReadLine());

if (sideA >= sideB + sideC)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideB >= sideA + sideC)
{
    Console.WriteLine("Invalid Triangle");
}
else if (sideC >= sideA + sideB)
{
    Console.WriteLine("Invalid Triangle");
}
else
{
    Console.WriteLine("Valid Triangle");
}
// Option 2: if ((sideA < sideB + sideC) &&
//(sideB < sideA + sideC) &&
//(sideC < sideA + sideB))
//{
//   Console.WriteLine("Valid Triangle");
//}
//else
//{
//   Console.WriteLine("Invalid Triangle");
//}