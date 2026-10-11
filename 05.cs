Person person = new Person();
person.Name = "Ana";
person.Age = 20;

Console.WriteLine($"{person.Name} - {person.Age}");

person.Age = -50;
Console.WriteLine($"{person.Name} - {person.Age}");

class Person {
  private string name;
  private int age;

  public string Name {
    get { return name; }
    set { name = value; }
  }

  public int Age {
    get { return age; }
    set {
      if (value >= 0) {
        age = value;
      }
    }
  }
}
