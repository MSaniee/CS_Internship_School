using School.Domain;

namespace School.Infrastructure;

public class Repository<T> where T : IUser, new()
{
    public List<T> Database { get; set; } = new();

    private readonly Dictionary<int, T> _cache;

    public Repository()
    {
        _cache = new();
    }

    public T Register(T t)
    {
        Database.Add(t);

        _cache.Add(t.Id, t);

        return t;
    }

    public void Delete(T t)
    {
        Database.Remove(t);

        _cache.Remove(t.Id);
    }

    public T CreateNew()
    {
        T t = new();

        Database.Add(t);

        return t;
    }

    public string GetFullNameById(int id)
    {
        T t = _cache[id];

        if(t is null) t = Database.First(t => t.Id == id);

        return t.GetFullName();
    }
}

