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



        }
    }
}