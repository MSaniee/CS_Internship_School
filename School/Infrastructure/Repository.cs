using School.Domain;

namespace School.Infrastructure;

public class Repository<T> where T : IUser, new()
{
    public List<T> Database { get; set; } = new();

    public T Register(T t)
    {
        Database.Add(t);

        return t;
    }

    public void Delete(T t)
    {
        Database.Remove(t);
    }

    public T CreateNew()
    {
        T t = new();

        Database.Add(t);

        return t;
    }

    public string GetFullNameById(int id)
    {
        T t = Database.First(t => t.Id == id);

        return t.GetFullName();
    }
}

