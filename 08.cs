bool running = true;
List<Teacher> teachers = [];
string message = "";

while (running) {
  Console.Clear();
  ShowTitle();
  ShowMenu();

  if (message != "") {
    Console.WriteLine();
    Console.WriteLine(message);
    message = "";
  }

  int option;
  do {
    Console.Write("Choose: ");
  } while (!int.TryParse(Console.ReadLine(), out option) || option is < 0 or > 4);

  switch (option) {
    case 1:
      message = AddTeacher(teachers);
      break;

    case 2:
      message = ShowTeachers(teachers);
      break;

    case 3:
      message = ShowTeacherCount(teachers);
      break;

    case 4:
      message = ShowAverageExperience(teachers);
      break;

    case 0:
      running = false;
      break;
  }
}

Console.Clear();
Console.WriteLine("Goodbye.");

void ShowTitle() {
  Console.WriteLine();
  Console.WriteLine("Teacher System");
  Console.WriteLine("==============");
}

void ShowMenu() {
  Console.WriteLine();
  Console.WriteLine("1. Add teacher");
  Console.WriteLine("2. Show teachers");
  Console.WriteLine("3. Count teachers");
  Console.WriteLine("4. Average experience");
  Console.WriteLine("0. Exit");
}

string AddTeacher(List<Teacher> teachers) {
  string name;
  do {
    Console.Write("Enter name: ");
    name = Console.ReadLine() ?? "";
  } while (string.IsNullOrWhiteSpace(name));

  string subject;
  do {
    Console.Write("Enter subject: ");
    subject = Console.ReadLine() ?? "";
  } while (string.IsNullOrWhiteSpace(subject));

  int years;
  do {
    Console.Write("Enter years of experience: ");
  } while (!int.TryParse(Console.ReadLine(), out years) || years < 0);

  teachers.Add(new Teacher(name, subject, years));
  return "Teacher added.";
}

string ShowTeachers(List<Teacher> teachers) {
  if (teachers.Count == 0) {
    return "No teachers yet";
  }

  string list = "";
  for (int i = 0; i < teachers.Count; i++) {
    list += $"{i+1}. {teachers[i].ShowProfile()}\n";
  }
  return list;
}

string ShowTeacherCount(List<Teacher> teachers) {
  return $"There {(teachers.Count == 1 ? "is" : "are")} {teachers.Count} teacher{(teachers.Count == 1 ? "" : "s")}.";
}

string ShowAverageExperience(List<Teacher> teachers) {
  if (teachers.Count == 0) {
    return "No teachers yet";
  }

  return $"Average experience: {teachers.Average(t => t.YearsOfExperience):F1} years";
}

class Teacher {
  private string name;
  private string subject;
  private int yearsOfExperience;

  public string Name {
    get { return name; }
    set { name = value; }
  }

  public string Subject {
    get { return subject; }
    set {
      if (!string.IsNullOrWhiteSpace(value)) {
        subject = value;
      }
    }
  }

  public int YearsOfExperience {
    get { return yearsOfExperience; }
    set {
      if (value >= 0) {
        yearsOfExperience = value;
      }
    }
  }

  public Teacher(string name, string subject, int yearsOfExperience) {
    Name = name;
    Subject = subject;
    YearsOfExperience = yearsOfExperience;
  }

  public string ShowProfile() {
    return $"{Name} - {Subject} - {YearsOfExperience} years of experience";
  }
}
