using School.Domain.UserAggregate;
using School.Infrastructure.Repositories;
using System.Xml.Linq;

Student student = new("Mohsen");
List<Student> db = new();
IStudentRepository studentRepository = new StudentRepository(db);

studentRepository.Add(student);

Console.WriteLine("Hello...");
//var task1 = GetDisciplineScore(student, 4);
//var task2 = GetFinalExamScores(student);
//var task3 = GetAccountantsApproval(student);

//var tasks = new List<Task> { task1, task2, task3 };

//while(tasks.Count > 0)
//{
//    Task finishedTask = await Task.WhenAny(tasks);

//    if(finishedTask == task1)
//    {
//        Console.WriteLine("Discipline Score is ready");
//    }
//    else if (finishedTask == task2)
//    {
//        Console.WriteLine("Final Exam Scores are ready");
//    }
//    else if(finishedTask == task3)
//    {
//        Console.WriteLine("Accountants Approval is ready");
//    }

//    await finishedTask;

//    tasks.Remove(finishedTask);
//}


//ReportCard reportCard = await GetReportCard(student);
//Console.WriteLine($"{student.Name} is graduated :)");




//static async Task<ReportCard> GetReportCard(Student student)
//{
//    Console.WriteLine("Getting Report Card...");
//    await Task.Delay(3000);
//    Console.WriteLine("Report Card is got");
//    return new ReportCard();
//}

//async Task GetAccountantsApproval(Student wood)
//{
//    Console.WriteLine("Geting Accountants Approval...");
//    await Task.Delay(3000);
//    Console.WriteLine("Accountants Approval is got");
//}

//async Task GetFinalExamScores(Student wood)
//{
//    Console.WriteLine("Getting the Final Exam Scores...");
//    await Task.Delay(3000);
//    Console.WriteLine("the Final Exam Scores is got");
//}

//async Task GetDisciplineScore(Student student, int termNumber)
//{
//    Console.WriteLine("Getting the Discipline Score...");
//    for (int i = 0; i < termNumber; i++)
//    {
//        await Task.Delay(1000);
//    }
//    Console.WriteLine("the Discipline Score is got");
//}

//// These classes are intentionally empty for the purpose of this example.

//internal class ReportCard { }


//List<Student> db = new();

//db = SeedData.GetSeedData();

//IStudentRepository studentRepo = new StudentRepository(db);
//IStudentService studentService = new StudentService(studentRepo);


//bool boolTest1 = studentRepo.IsAllStudentsPassedFinalExam();

//bool boolTest2 = studentRepo.ExistsStudent(6);

//int count1 = studentRepo.CountStudentsPassedFinalExam();

//Student bestStudent = studentRepo.GetBestStudent();

//var result = studentRepo.GetAllStudents();

//studentService.OnRegistered += SendSms;
//var student1 = studentService.Register("Mohsen");

//try
//{
//    Student student = studentService.GetById(10);
//}
//catch(NotFoundException ex) when (ex.Status == "Green")
//{
//    Console.WriteLine($"Stuednet Id : {ex.StudentId} {ex.Message}");
//}
//catch (Exception ex)
//{
//    Console.Write("Exception Is Handled...");
//}


//Console.WriteLine("Finish...");

//bool CheckStudent(Student student)
//{
//    return true;
//}

//void SendSms()
//{
//    Console.WriteLine("Send sms");
//}

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

