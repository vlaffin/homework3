// //№19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

// Console.WriteLine("ведите пятизначное число а программа скажет является ли оно палиндромом ");
// int num = int.Parse(Console.ReadLine());
//    if (num < 10000 || num > 99999) { Console.WriteLine("Вы ввели не пятизначное число");}
    
//    if(num / 1000 == num % 100) { Console.WriteLine("число является палиндромом");}

//   else { Console.WriteLine("Число не является палиндромом");}

//№21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//  int xa, ya, za, xb, yb, zb;
//  Console.WriteLine("Введите координату x точки a:");
//  while (!int.TryParse(Console.ReadLine(), out xa)) {Console.Write("Введён неверный параметр");}

//  Console.WriteLine("Введите координату y точки a:");
//  while (!int.TryParse(Console.ReadLine(), out ya)) {Console.Write("Введён неверный параметр");}
 
//  Console.WriteLine("Введите координату z точки a:");
//  while (!int.TryParse(Console.ReadLine(), out za)) {Console.Write("Введён неверный параметр");}
 
//  Console.WriteLine("Введите координату x точки b:");
//   while (!int.TryParse(Console.ReadLine(), out xb)) {Console.Write("Введён неверный параметр");}
 
//  Console.WriteLine("Введите координату y точки b:");
//  while (!int.TryParse(Console.ReadLine(), out yb)) {Console.Write("Введён неверный параметр");}

//  Console.WriteLine("Введите координату z точки b:");
//  while (!int.TryParse(Console.ReadLine(), out zb)) {Console.Write("Введён неверный параметр");}
 
//  double Distance(double xa, double ya, double za, double xb, double yb, double zb)
//  {
//    double result = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow((zb-za), 2));
//    return result;
//  }
//  double result = Distance(xa, ya, za, xb, yb, zb);
//  Console.WriteLine("Расстояние между 2 точками : " + result);
 
//№23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//  Console.WriteLine("Введите число N, а программа выведет таблицу кубов от 1 до N : ");
//  int.TryParse(Console.ReadLine(), out int x);

//  double Func(int x) {return Math.Pow(x, 3);}
//  int i = 1;
//  while (i<=x) 
//   {
//   Console.Write(Func(i));
//    if(i<x)
//      Console.Write(",");
//    i++;
//  }
