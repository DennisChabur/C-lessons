// Задача 6
int a;
string userEnter1;

userEnter1 = Console.ReadLine();

a = int.Parse(userEnter1);


if(a % 2 == 1)
{
    Console.Write($"{a} is odd");
}
else
{
    Console.Write($"{a} is even");
}