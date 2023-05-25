// Task 1
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
    
}

Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Числа в промежутке [{num}, 1] -> ");
ShowNums(num);


// Task 2
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*

int SummNumbersProme(int num1, int num2)
{
    if(num1 > num2) return SummNumbersProme(num1 - 1, num2) + num1;
    if(num2 > num1) return SummNumbersProme(num1 + 1, num2) + num1;
    return num1;
   
}

Console.Write("Введите первое число = ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число = ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промжутке [{num1},{num2}] = {SummNumbersProme(num1,num2)}");

*/

//Task 3 
// Напишите программу вычисления функции Аккермана с по5мощью рекурсии. Даны два неотрицательных числа m и n

/*
int FunckAkkermana(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return FunckAkkermana(m - 1, 1);
    else
        return FunckAkkermana(m - 1, FunckAkkermana(m, n - 1));
}

Console.Write("Введите первое неотрицательное число = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число = ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Функция Аккермана {m} и {n} = {FunckAkkermana(m,n)}");
*/