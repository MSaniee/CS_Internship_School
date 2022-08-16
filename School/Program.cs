using School.Domain;
using School.Infrastructure;
using School.Services;


Teacher teacher1 = new(1, "Mohsen", "Saniee");
Teacher teacher2 = new(2, "Reza", "Rezaee");

//Repository<Teacher> teacherRepo = new();
Repository<Student> studentRepo = new();

//teacherRepo.Register(teacher1);
//teacherRepo.Register(teacher2);

//string techer2FullName = teacherRepo.GetFullNameById(2);

Student student1 = new(1, "Ahmad", "Ahmadi");
Student student2 = new(2, "Reza1", "Ahmadi");
Student student3 = new(3, "Reza2", "Ahmadi");
Student student4 = new(4, "Reza3", "Ahmadi");
studentRepo.Register(student1);
studentRepo.Register(student2);

string student1FullName = studentRepo.GetFullNameById(1);
string student2FullName = studentRepo.GetFullNameById(2);

Student student = new(12);

Student[] array = new[] { student1, student2, student3, student4 };

bool reza2Exists = Array.Exists(array, s => s.FirstName == "Mohsen");

Student studentReza1 = Array.Find(array, s => s.Id == 2);

Array.ForEach(array, s => 
{
    if (s.Id == 4) s.FirstName = "Meysam";
});

bool allIsTrue = Array.TrueForAll(array, s => s.FirstName == "Ahmadi");

Student meysam = Array.Find(array, s => s.Id == 4);

IStudentService service = new StudentService2();

service.MoveToHome(student);

Console.WriteLine("Hello, World!");
