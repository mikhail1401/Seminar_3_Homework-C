Console.WriteLine("\nTask 19");
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом
// 14212 -> No     23432 -> Yes    12821 -> Yes

int num = new Random().Next(10000, 100000);
Console.WriteLine($"The initial number is {num}");

if ((num/10000==num%10)&&(num/1000%10==num/10%10))
{
    Console.WriteLine($"{num} is a palindrome");
}
else
{
    Console.WriteLine($"{num} isn't a palindrome");
}


Console.WriteLine("\nTask 21");
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A(3,6,8); B(2,1,-7) -> 15.84
// A(7,-5,0); B(1,-1,9) -> 11.53

Console.WriteLine("Type X for point A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Y for point A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Z for point A: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type X for point B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Y for point B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type Z for point B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double s = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math. Pow((z2-z1), 2));

Console.WriteLine($"The distance between point A and point B equals {s}.");


Console.WriteLine("\nTask 23");
// Наишите программу, которая принимает на вход число (N) и выдает таблицу кубов
// чисел от 1 до N.
// 3 -> 1, 4, 9
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Type a number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
int number = 1;
int index = 0;

while(index<n)
{
    array[index]=number*number;
    index+=1;
    number+=1;
}

for (int i = 0; i < n; i++)
{
    Console.WriteLine(array[i]);
}
