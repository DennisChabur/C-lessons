// Задача 4
int a, b, c;
string userEnter1;
string userEnter2;
string userEnter3;

userEnter1 = Console.ReadLine();
userEnter2 = Console.ReadLine();
userEnter3 = Console.ReadLine();

a = int.Parse(userEnter1);
b = int.Parse(userEnter2);
c = int.Parse(userEnter3);


if(a > b)
{
    if(b > c)
    {
        Console.Write($"max is {a}, and min is {c}");
    }
    else
    {
        Console.Write($"max is {a}, and min is {b}");
    }
}
else if (b > c)
{
    if(c > a)
    {
        Console.Write($"max is {b}, and min is {a}");
    }
    else
    {
        Console.Write($"max is {b}, and min is {c}");
    }
}
else
{
    if(a > b)
    {
        Console.Write($"max is {c}, and min is {b}");
    }
    else
    {
        Console.Write($"max is {c}, and min is {a}");
    }
}