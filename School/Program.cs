using School.Domain;
using School.Infrastructure;
using School.Services;
using System.Collections.Generic;

Teacher teacher1 = new(1, "Mohsen", "Saniee");
Teacher teacher2 = new(2, "Reza", "Rezaee");

Repository<Teacher> teacherRepo = new();
Repository<Student> studentRepo = new();

teacherRepo.Register(teacher1);
teacherRepo.Register(teacher2);

string techer2FullName = teacherRepo.GetFullNameById(2);

Student student1 = new(1, "AhmadS", "Ahmadi");
Student student2 = new(2, "RezaS", "Ahmadi");
Student student3 = new(3, "PeymanS", "Ahmadi");
Student student4 = new(4, "NavidS", "Ahmadi");
Student student5 = new(5, "BehnamS", "Ahmadi");
studentRepo.Register(student1);
studentRepo.Register(student2);

string student1FullName = studentRepo.GetFullNameById(1);
string student2FullName = studentRepo.GetFullNameById(2);

Student student = new(12);

IStudentService service = new StudentService2();

service.MoveToHome(student);


Student[] studentArray = new[] { student1, student2, student3, student4, student5 };

bool AhmadExists = Array.Exists(studentArray, s => s.FirstName == "Ahmad");
bool MohsenExists = Array.Exists(studentArray, s => s.FirstName == "Mohsen");

Student myStudent = Array.Find(studentArray, s => s.Id == 3);

Array.ForEach(studentArray, u => 
{
    if (u.Id == 4) u.FirstName = "Saeed";
});

string student4FirstName = Array.Find(studentArray, s => s.Id == 4).FirstName;
bool allIsTrue = Array.TrueForAll(studentArray, s => s.FirstName.Contains('S'));

List<Student> list = new() { student1, student2};

list.ForEach(u =>
{
    if (u.Id == 4) u.FirstName = "Saeed";
});

list.TrueForAll(s => s.FirstName.Contains('S'));

Stack<Student> stack = new();

stack.Push(student1);
stack.Push(student2);

var studnetPop = stack.Pop();

Queue<Student> queue = new();
queue.Enqueue(student1);
queue.Enqueue(student2);

var studentDequeue = queue.Dequeue();

Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, World!");

foreach(var s in TestYeildMethod())
{
    var name = s.GetFullName();
}

IEnumerable<Student> TestYeildMethod()
{
    yield return student1;
    yield return student2;
    yield return student3;
}
