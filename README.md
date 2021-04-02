<h2>2021-04-01 ~ </h2> 
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
public override voide method(){
    base.method();
    new_logic();
}
```
