using School.Application;
using School.Application.Interfaces;
using School.Application.Services;
using School.Domain.UserAggregate;
using School.Infrastructure.Repositories;


List<Student> db = new();

IStudentRepository studentRepo = new StudentRepository(db);
IStudentService studentService = new StudentService(studentRepo);

try
{
    Student student = studentService.GetById(10);
}
catch(NotFoundException ex) when (ex.Status == "Green")
{
    Console.WriteLine($"Stuednet Id : {ex.StudentId} {ex.Message}");
}
catch (Exception ex)
{
    Console.Write("Exception Is Handled...");
}


Console.WriteLine("Finish...");

//Forcing Garbage Collection In C#
//CreateUsers();
//Console.WriteLine("Memory used before: {0:N0}", GC.GetTotalMemory(false));
//GC.Collect();
//Console.WriteLine("Memory used after: {0:N0}", GC.GetTotalMemory(true));


//void CreateUsers(int number = 100)
//{
//    Student student;
//    for (int i = 0; i < 100; i++)
//    {
//        student = new Student();
//    }
//}


//IDisposable Interface in C#

//List<Student> db = new();
////var studentRepo = new StudentRepository(db);

//using var studentRepo = new StudentRepository(db);
////or
//studentRepo.Dispose();
//Console.WriteLine("Hello, World!");


//Garbage Collection Example
//Console.WriteLine("GC Maximum Generations:" + GC.MaxGeneration);
//Console.WriteLine("Total Memory:" + GC.GetTotalMemory(false));
//Student student1 = new();
//Console.WriteLine("myObject Generation is :" + GC.GetGeneration(student1));







//List<Student> db = new();
//IStudentRepository studentRepository = new StudentRepository(db);


//Teacher teacher1 = new(1, "Mohsen", "Saniee");
//Teacher teacher2 = new(2, "Reza", "Rezaee");

////Repository<Teacher> teacherRepo = new();
//Repository<Student> studentRepo = new();

////teacherRepo.Register(teacher1);
////teacherRepo.Register(teacher2);

////string techer2FullName = teacherRepo.GetFullNameById(2);

//Student student1 = new(1, "Ahmad", "Ahmadi");
//Student student2 = new(2, "Reza1", "Ahmadi");
//Student student3 = new(3, "Reza2", "Ahmadi");
//Student student4 = new(4, "Reza3", "Ahmadi");
//studentRepo.Register(student1);
//studentRepo.Register(student2);

//string student1FullName = studentRepo.GetFullNameById(1);
//string student2FullName = studentRepo.GetFullNameById(2);

//Student student = new(12);

//Student[] array = new[] { student1, student2, student3, student4 };

//bool reza2Exists = Array.Exists(array, s => s.FirstName == "Mohsen");

//Student studentReza1 = Array.Find(array, s => s.Id == 2);

//Array.ForEach(array, s => 
//{
//    if (s.Id == 4) s.FirstName = "Meysam";
//});

//bool allIsTrue = Array.TrueForAll(array, s => s.FirstName == "Ahmadi");

//Student meysam = Array.Find(array, s => s.Id == 4);

//IStudentService service = new StudentService2();

//service.MoveToHome(student);

