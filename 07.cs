List<Course> courses = [];

courses.Add(new Course("Mathematics", 6));
courses.Add(new Course("Programming", 8));
courses.Add(new Course("Databases", 5));

foreach (Course course in courses) {
  Console.WriteLine($"{course.Name} - {course.Credits} credits");
}

class Course {
  public string Name;
  public int Credits;

  public Course(string name, int credits) {
    Name = name;
    Credits = credits;
  }
}
