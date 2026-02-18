namespace Day1.Repositories
{
    public interface IRepository<T>
    {
        void Delete(int Id);
        T GetById(int Id);
        IQueryable<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Save();
    }
}
