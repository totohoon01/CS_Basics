using System;

namespace ClassSynTax
{
    public class Parent
    {
        private string name;

        //생성자
        public Parent(string _name)
        {
            this.name = _name;
        }

        //getter, setter
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        //method
        public virtual void Hello()
        {
            System.Console.WriteLine($"Hello, {this.name}");
        }
    }

    //inheritance
    public class Child : Parent
    {
        private int age;
        //부모 클래스의 변수를 이용해 초기화
        public Child(string _name, int _age) : base(_name)
        {
            this.age = _age;
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        //메서드 오버라이딩
        public override void Hello()
        {
            System.Console.WriteLine($"Hello, {this.Name}, {this.age}");
        }
    }
}