Course course = new Course();
course.Name = "Object Oriented Programming";
course.Credits = 6;
course.Teacher = "Dr. Martinez";

Console.WriteLine($"Course: {course.Name}");
Console.WriteLine($"Credits: {course.Credits}");
Console.WriteLine($"Teacher: {course.Teacher}");

class Course {
  public string Name;
  public int Credits;
  public string Teacher;
}
