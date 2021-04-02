using System;
using DAY1;
using ClassSynTax;
using DelegateSyntax;

namespace CSrecap
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day 1
            Day1Contents d1 = new Day1Contents();

            ///Day 2 - classes
            Parent p1 = new Parent("Hoon");
            p1.Hello();
            Child c1 = new Child("Hoon", 29);
            c1.Name = "HoonK";
            c1.Hello();

            //Day 2 - Delegate
            DelegateDemo del1 = new DelegateDemo();
            del1.PrintWhatEver(10);
            del1.PrintWhatEver(10.0f);
            del1.PrintWhatEver("111");
            del1.RunHandlers();
        }
    }
}
