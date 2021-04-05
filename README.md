<h2>2021-04-01 ~ 201-04-05</h2> 
<h4>C# Basics</h4>
<ol>
    <li> VSCODE <i><b>"Add Folder to WorkSpace", "Save WorkSpace as"</b></i></li>
    <li> Initializing C# WorkSpace : <code><b>dotnet new console</b></code></li>
    <li> Run Script : <code><b>dotnet run</b></code></li>
</ol>

<h5>Class</h5>
<ul>
    <li><b>함수와 변수의 집합</b></li>
    <li><b>접근 지시자</b>
        <ol>
        <li>public : 외부 클래스 접근 가능</li>
        <li>private : 외부 클래스 접근 불가</li>
        </ol>
    </li>
    <li><b>객체지향 언어 특징</b>
        <ol>
        <li>필드(Field) : 내부 변수(외부에서 접근 불가)</li>
        <li>프로퍼티(Properties) : 외부에서 접근 가능한 변수</li>
        <li>메서드(Method) : 함수(Function)</li>
        <li>이벤트(Event) : 특정 조건을 만족했을 때 호출되는 함(콜백)</li>
        </ol>
    </li>
</ul>
<h6>getter, setter, inheritance</h6>

```
public class User : Parent {}
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
User p1 = new User();
p1.Name = "Hoon"; //setter
Console.WriteLine(p1.Name) //getter
```

<h6>virtual / override</h6>
부모 클래스의 메서드를 상속, 로직을 추가<br>

```
public virtual void method(){}
public override void method(){
    base.method();
    new_logic();
}
```

<h5>DeleGate</h5>
델리게이트 -> <b>함수</b>를 저장할 수 있는 변수

```
delegate void SumHandler(int a, int b); //형태를 선언하고
SumHandler sumHandler; //델리게이트 핸들러 변수 생성

void Sum(int a, int b)
{
    System.Console.WriteLine(a + b);
}
void Minus(int a, int b)
{
    System.Console.WriteLine(a - b);
}


public void Work02()
{
    sumHandler += Sum;  //핸들러에 함수 연결1
    sumHandler += Minus; //2
    sumHandler(10, 5);
}
```
