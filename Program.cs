// Задача 2
int a, b;
string userEnter1;
string userEnter2;

userEnter1 = Console.ReadLine();
userEnter2 = Console.ReadLine();

a = int.Parse(userEnter1);
b = int.Parse(userEnter2);


if(a > b)
{
    Console.Write($"max is {a}, and min is {b}");
}
else if (a == b)
{
    Console.Write($"There is no max and min number. {a} and {b} is equal");
}
else
{
    Console.Write($"max is {b}, and min is {a}");
}