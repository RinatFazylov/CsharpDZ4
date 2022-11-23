// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{
int count = Convert.ToString(numberN).Length;
int advance = 0;
int result = 0;
for (int i = 0; i < count; i++)
{
advance = numberN - numberN % 10;
result = result + (numberN - advance);
numberN = numberN / 10;
}
return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);












// С решением сверху мне подсказали, мой код намного больше. Если возможно,
// помогите найти ошибку, почему некоторые числа неправильно ссумируются

// Console.WriteLine("Введите число :");
// int number = Convert.ToInt32(Console.ReadLine());
// int Num(int num)
// {
//     int sum = 0;
//     int count = 10;
//     int x = num;
//     int result = 0;
//     int sum1= 0;
//     while ((num / count) > 0)     // 54321
//     {
//         x = num % count;   // 1 2 
//         while (x > 10)
//         {
//             x = x / 10;
//         }
//         count = count * 10;
//         sum = x + sum;
//     }
//         sum1 = num;
//         while (sum1 > 10)
//         {
//             sum1 = sum1 / 10;
//         }
//         result = sum + sum1;
    
//     return result;
// }


// int result = Num(number);
// Console.WriteLine($"{result}");
