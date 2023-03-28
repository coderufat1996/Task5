using System.Globalization;

namespace Tapsiriqlar5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //int sum = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    sum += i;
            //}
            //if (sum % 7 == 0)
            //{
            //    Console.WriteLine("1 den mine qeder ededlerin cemi 7 e bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("ededlerin cemi 7 e bolunmur");
            //}
            #endregion
            #region Task2
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 7 == 0 && i % 8 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task3
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task4
            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 3 == 0 && i % 10 != 3)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task5
            //int cem = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int number = i;
            //    while (number > 0)
            //    {
            //        cem += (number % 10);
            //        number /= 10;
            //    }
            //    if (i % 5 == 0 && cem % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            #endregion
            #region Task6
            //for (int i = 1; i <= 1000; i++)
            //{
            //    int sum = 0;
            //    int number = i;
            //    while (number > 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;
            //    }
            //    int bir = i / 100;
            //    if (i % 2 == 0 && sum % 2 != 0 && bir % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task7
            //for (int i = 1; i <= 1000; i++)
            //{
            //    bool hasthree = false;
            //    int number = i;
            //    while (number > 0)
            //    {
            //        if (number % 10 == 3)
            //        {
            //            hasthree = true;
            //            break;
            //        }
            //        number /= 10;
            //    }
            //    if (!hasthree)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task8
            //int max = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    bool hasThree = false;
            //    int number1 = i;
            //    int number2= i;
            //    while (number1 > 0)
            //    {
            //        if (number1 % 10 == 3)
            //        {
            //            hasThree= true;
            //            break;
            //        }
            //        number1 /= 10;
            //    }
            //    int cem = 0;
            //    if (!hasThree)
            //    {
            //        while (number2 > 0)
            //        {
            //            cem += number2 % 10;
            //            number2 /= 10;
            //        }
            //        if (cem == 3)
            //        {
            //            if (i > max)
            //            {
            //                max = i;
            //            }
            //        }
            //    }

            //}
            //Console.WriteLine($"Netice:{max}");
            #endregion
            #region Task9
            //int number;
            //int cem = 0;
            //int countofdigit = 0;
            //for (int i = 11; i<= 1000; i++)
            //{
            //    number = i;
            //    while (number > 0)
            //    {
            //        cem += number % 10;
            //        number /= 10;
            //    }
            //    if (cem > 11)
            //    {
            //        countofdigit++;
            //        if (countofdigit == 11)
            //        {
            //            Console.WriteLine(i);
            //            break;
            //        }
            //    }
            //    cem = 0;

            //}
            #endregion
            #region Task10
            //int number, cem;
            //int max = 0;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    cem = 0;
            //    if (i % 2 == 0)
            //    {
            //        number = i;
            //        while (number > 0)
            //        {
            //            cem += number % 10;
            //            number /= 10;
            //        }
            //        if (cem > 5 && cem < 7)
            //        {
            //            if (i > max)
            //            {
            //                max = i;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(max);
            #endregion
            #region Task11
            //int sum, digit, temp, digitSum;
            //for (int i = 1; i <= 1000; i++)
            //{
            //    l1:
            //    sum = 0;
            //    digitSum = 0;
            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;
            //        if (digit == 3)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        digitSum += digit;
            //        sum = sum * 10 + digit;
            //        temp /= 10;

            //    }
            //    if (i == sum && digitSum > 10)
            //    {
            //        Console.WriteLine(i); 
            //    }
            //}
            #endregion
            #region Task12
            //int eded1, eded2, cem, num1, num2;
            //for (int i = 1; i <= 100000; i++)
            //{
            //    bool netice = true;
            //    eded1 = i;
            //    int son = eded1 % 10;
            //    while (eded1 > 0)
            //    {
            //        num1 = eded1 % 10;
            //        if (num1 != son)
            //        {
            //            netice = false;
            //        }
            //        eded1 /= 10;
            //    }
            //l1:
            //    cem = 0;
            //    eded2 = i;
            //    while (eded2 > 0)
            //    {
            //        num2=eded2 % 10;
            //        if (num2 == 5)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        cem += num2;
            //        eded2 /= 10;
            //    }
            //    if (netice && cem > 5)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task13
            //int cem, eded1, eded2, num1, num2, netice;
            //for (int i = 1; i <= 100000; i++)
            //{l1:
            //    cem = 0;
            //    netice = 0;
            //    num2 = i;
            //    while (num2 > 0)
            //    {
            //        eded2 = num2 % 10;
            //        if (eded2 % 2 == 0)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        netice += eded2;
            //        cem = cem * 10 + eded2;
            //        num2 /= 10;
            //    }
            //    num1 = i;
            //    bool bes = false;
            //    while (num1 > 0)
            //    {
            //        eded1= num1 % 10;
            //        if (eded1 != 5)
            //        {
            //            bes=true;
            //            break;
            //        }
            //        num1 /= 10;
            //    }
            //    if (i == cem && bes)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task14
            //int eded1, eded2, eded3, num1, num2, num3, cem, count;
            //bool bes, bir;
            //for (int i = 1; i <= 100000; i++)
            //{
            //    count = 0;
            //    bes = false;
            //    num1 = i;
            //    while (num1 > 0)
            //    {
            //        eded1 = num1 % 10;
            //        if (eded1 == 5)
            //        {
            //            count++;
            //            if (count >= 2)
            //            {
            //                bes = true;
            //            }

            //        }
            //        num1 /= 10;
            //    }
            //    num2 = i;
            //    bir = false;
            //    while (num2 > 0)
            //    {
            //        eded2 = num2 % 10;
            //        num2 /= 10;
            //        if (eded2 == 11)
            //        {
            //            bir = true;
            //        }
            //    }
            //l1:
            //    cem = 0;
            //    num3 = i;
            //    while (num3 > 0)
            //    {
            //        eded3= num3 % 10;
            //        if (eded3 == 6)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        cem += eded3;
            //        num3/= 10;

            //    }
            //    if (cem > 7 && cem < 15 && bes && bir)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion
            #region Task15
            //int temp, digit, sum;
            //int[] tam = { 0, 1, 5, 7, 9 };
            //for (int i = 1; i < 10000; i++)
            //{
            //l1:
            //    sum = 0;
            //    if (i % 2 == 0 || (i % 3 == 0 && i != 3) || i % 5 == 0 || i % 7 == 0)
            //    {
            //        continue;
            //    }
            //    temp = i;
            //    while (temp > 0)
            //    {
            //        digit = temp % 10;
            //        if (Array.IndexOf(tam, digit) != -1)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum += digit;
            //        temp /= 10;
            //    }
            //    while (sum > 0)
            //    {
            //        digit=sum% 10;
            //        if (digit == 2)
            //        {
            //            i++;
            //            goto l1;
            //        }
            //        sum/= 10;   
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion




        }
    }
}