// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"

// N = 6 -> "1, 2, 3, 4, 5, 6"

// Делаем с помощью рекурсии

// void OneToN(int n)
// {
//     if (n > 0)
//     {
//         OneToN(n - 1);
//         System.Console.Write(n + " ");
//     }
// }

// OneToN(6);
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.


// static int Akk(int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else
//       if ((n != 0) && (m == 0))
//         return Akk(n - 1, 1);
//     else
//         return Akk(n - 1, Akk(n, m - 1));
// }

// Console.WriteLine(Akk(1, 2));

// Console.ReadKey();

// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы

using System;   
namespace New_Project 
{  
  public static class Program  
  { 
    public static void print(int [] A, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(A[n] + " "); 
      	print(A, n - 1); 
      } 
      else Console.WriteLine(A[0]); 
    } 
    public static void Main()   
    { 
      int [] num = {1, 2, 5, 0, 10, 34}; 
      print(num, num.Length - 1); 
    }  
  }   
}
