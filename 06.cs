Course.ShowMessage();

Course course1 = new Course("Mathematics");
Course course2 = new Course("Programming");
Course course3 = new Course("Databases");

Console.WriteLine($"Total courses: {Course.TotalCourses}");

class Course {
  public string Name;
  public static int TotalCourses = 0;

  public Course(string name) {
    Name = name;
    TotalCourses++;
  }

  public static void ShowMessage() {
    Console.WriteLine("Welcome to the course system!");
  }
}
