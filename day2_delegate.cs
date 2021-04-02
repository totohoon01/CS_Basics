using System;

namespace DelegateSyntax
{
    class DelegateDemo
    {
        //PolyMophics
        public void PrintWhatEver<T>(T data)
        {
            System.Console.WriteLine($"{typeof(T)}, {data}");
        }
        delegate void CalcHandler<T>(T num1, T num2); //타입을 정의
        CalcHandler<int> calcInt; //변수 생성
        void AddInt(int a, int b)
        {
            System.Console.WriteLine(a + b);
        }

        CalcHandler<float> calcFloat;

        public void RunHandlers()
        {
            calcInt += AddInt;
            calcInt(10, 5);

            //무명 델리게이트
            calcFloat += delegate (float a, float b)
            {
                System.Console.Write("Chain 1: ");
                System.Console.WriteLine(a + b);
            };

            //람다식
            calcFloat += (float a, float b) =>
            {
                System.Console.Write("Chain 2: ");
                System.Console.WriteLine(a + b);
            };
            calcFloat(10.3f, 2.5f);

        }
    }
}