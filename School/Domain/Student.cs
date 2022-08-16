namespace School.Domain;

public class Student : IUser
{
    public static int totalCount;
    public const string SchoolName = "Shahid Rajaee";

    private readonly int _age;
    public Student()
    {

    }

    public Student(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public Student(int age)
    {
        _age = age;
    }

    private string _firstName;
    public string FirstName 
    { 
        get
        {
            return _firstName;
        } set 
        {
            if (value.Length > 20) _firstName = "default";
            else _firstName = value;
        }
    }

    public string LastName { get; set; }

    public GenderType GenderType { get; set; } = GenderType.FeMale;
    public int Id { get; set; }

    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }

    public string GetFullName(string firstName)
    {
        FirstName ??= firstName;

        return FirstName + " " + LastName;
    }


}

public enum GenderType
{
    Male,
    FeMale
}

