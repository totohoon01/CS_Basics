using System;

namespace DAY1
{
    enum DAY { MON, TUE, WED, THU, FRI, SAT, SUN };
    public class Day1Contents
    {
        public void Formatting()
        {
            string name = "Hoon";
            System.Console.WriteLine($"Hello, {name}");
        }
        public void DataTypes()
        {
            float num1 = float.MaxValue;
            double num2 = double.MaxValue;
            decimal num3 = decimal.MaxValue;
            System.Console.WriteLine($"{num1}, {num2}, {num3}");
        }
        public void WhatDate()
        {
            string today = DateTime.Now.DayOfWeek.ToString();
            switch (today)
            {
                case "Monday":
                    System.Console.WriteLine(DAY.MON);
                    break;
                case "Tuesday":
                    System.Console.WriteLine(DAY.TUE);
                    break;
                case "Wednesday":
                    System.Console.WriteLine(DAY.WED);
                    break;
                case "Thursday":
                    System.Console.WriteLine(DAY.THU);
                    break;
                case "Friday":
                    System.Console.WriteLine(DAY.FRI);
                    break;
                case "Saturday":
                    System.Console.WriteLine(DAY.SAT);
                    break;
                case "Sunday":
                    System.Console.WriteLine(DAY.SUN);
                    break;
                default:
                    break;
            }
        }
        public void Operator3()
        {
            System.Console.WriteLine((1 > 0) ? "TRUE" : "FALSE");
        }
        public void CondtionStatement()
        {
            bool isTrue = true;
            if (isTrue)
            {
                System.Console.WriteLine("TRUE");
            }
            else
            {
                System.Console.WriteLine("FASLE");
            }
        }
        public void LoopStatement()
        {
            //반복문 - for
            int sum = 0;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
            }
            System.Console.WriteLine(sum);

            //반복문 - while
            int count = 0;
            while (count < 3)
            {
                System.Console.WriteLine($"loop while count < 3, count={count}");
                count++;
            }
        }
        public void ArrayStatement()
        {
            //배열
            int[] intArray = new int[3] { 1, 2, 3 };
            foreach (int item in intArray) Console.Write($"{item} ");
            System.Console.WriteLine("");
            for (int i = 0; i < intArray.Length; i++) Console.Write($"{intArray[i]} ");
        }
    }
}
/*


            

            

            
*/