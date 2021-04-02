using System;

namespace CSrecap
{
    public class Parent {}
    //상속 : Parent
    public class User : Parent{
        //Field, Member Variables
        private string name;
        private int age;

        //Properties
        public string Name{
            get{
                return  this.name;
            }
            set{
                //write logic//
                this.name = value; //value에 값이 저장됨.
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //포맷팅 $
            string name = "Hoon";
            System.Console.WriteLine($"Hello, {name}");

            //실수형 데이터 타입
            float num1 = float.MaxValue;
            double num2 = double.MaxValue;
            decimal num3 = decimal.MaxValue;
            System.Console.WriteLine($"{num1}, {num2}, {num3}");

            //함수
            Hello(name);
            
            //열거형, switch/case
            WhatDate();

            //삼항 연산자
            System.Console.WriteLine((1>0)? "TRUE" : "FALSE");

            //조건문
            bool isTrue = true;
            if(isTrue){
                System.Console.WriteLine("TRUE");
            }
            else{
                System.Console.WriteLine("FASLE");
            }

            //반복문 - for
            int sum = 0;
            for(int i=0; i<=10; i++){
                sum += i;
            }
            System.Console.WriteLine(sum);

            //반복문 - while
            int count = 0;
            while(count < 3){
                System.Console.WriteLine($"loop while count < 3, count={count}");
                count++;
            }

            //배열
            int [] intArray = new int[3]{1,2,3};
            foreach(int item in intArray) Console.Write($"{item} ");
            System.Console.WriteLine("");
            for(int i=0; i<intArray.Length; i++) Console.Write($"{intArray[i]} ");

            //DAY2 - CLASS//
            User p1 = new User();
            p1.Name = "Hoon"; //setter
            Console.WriteLine(p1.Name) //getter
        }
        static void Hello(string name){
            System.Console.WriteLine($"Hello, {name}");
        }
        enum DAY{MON, TUE, WED, THU, FRI, SAT, SUN};
        static void WhatDate(){
            string today = DateTime.Now.DayOfWeek.ToString();
            switch(today){
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
    }
}
