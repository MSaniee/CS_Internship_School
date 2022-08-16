using School.Domain;
using School.Infrastructure;
using School.Services;


Teacher teacher1 = new(1, "Mohsen", "Saniee");
Teacher teacher2 = new(2, "Reza", "Rezaee");

Repository<Teacher> teacherRepo = new();
Repository<Student> studentRepo = new();

teacherRepo.Register(teacher1);
teacherRepo.Register(teacher2);

string techer2FullName = teacherRepo.GetFullNameById(2);

Student student1 = new(1, "Ahmad", "Ahmadi");
Student student2 = new(4, "Reza", "Ahmadi");
studentRepo.Register(student1);
studentRepo.Register(student2);

string student1FullName = studentRepo.GetFullNameById(1);
string student2FullName = studentRepo.GetFullNameById(4);

Student student = new(12);

IStudentService service = new StudentService2();

service.MoveToHome(student);

Console.WriteLine("Hello, World!");
