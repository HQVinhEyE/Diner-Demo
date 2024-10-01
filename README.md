## Coding Convention for Map Project:

### Naming Convention
- Namespaces are all PascalCase.
  ```csharp
  namespace MyNamespace{}
  ```
- Classes & Methods are all PascalCase.
  ```csharp
  public class MyClass{}
  ```
- Fields are camelCase, including public ones, but Static fields are PascalCase.
  ```csharp
  private int myInt = 0;
  public static int MyStaticInt = 1;
  ```
- Properties are PascalCase.
  ```csharp
  private void MyMethod()
  {
  }
  ```
- Parameters should be camelCase.
  ```csharp
  private void MyMethod(int myParam)
  {
  }
  ```
- Constants and readonly fields should be UPPERCASE, ex: MY_CONST, MY_READONLY_VALUE.
  ```csharp
  public const string MY_CONST = "Constant";
  public readonly string MY_READONLY_VALUE = "Readonly";
  ```
- Interface are IPascalCase that start with preface I.
  ```csharp
  public Interface IMyFeature{}
  ```

  
### Best Practices with C#
- Contain classes inside namespace to avoid name overlapped and conflicts.
  ```csharp
  namespace MyNamespace{
    public class MyClass{}
  }
  ```
- Always include access level modifiers when declare.
  ```csharp
  //Bad
  void Start()
  {
  }
  
  //Good
  private void Start()
  {
  }
  ```
- Public fields should only be access by a getter-setter method.
  ```csharp
  //Bad
  public int MyInt = 1;
  
  //Good
  private int myInt = 1;
  public int MyInt
  {
    get
    {
      return this.myInt;
    }
    set
    {
      myInt = value;
    }
  }
  ```
- Always define string into Constants for consistency.
  ```csharp
  //Bad
  PrintThisString("the string");

  //Good
  private const string MY_STRING = "the string";
  PrintThisString(MY_STRING");
  ```

  
### Best practices with C# with Unity features
- DO NOT use Invoke and SendMessage.
- DO NOT use expensive methods (FindObject, GetComponent. Instantiate, Destroy, Resource.Load, GetChild) in Update. Should Cache them if need to use multiple times.
- Inherited methods from MonoBehavior should be written right after declaring variables.
- Do not Invoke public methods by using unity editor's component if possible.
- Classes should be less than 1000 lines with every methods less than 100 lines.
- Complicated methods should have instruction/notice comments with param definitions.
- Managers classes could be used with singletons and static methods, but it should be independence from the scene constraints.


