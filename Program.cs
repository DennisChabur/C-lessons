// Задача 8
int a;
string userEnter1;

userEnter1 = Console.ReadLine();

a = int.Parse(userEnter1);

int i = 2;
while (i < a)
{
    Console.Write($"{i} ");
    i += 2;
}