namespace Day1.Services
{
    public interface IService<T>
    {
        List<T> GetAll();
        void Add(T obj);

        T GetById(int Id);

        void Update(int Id, T obj);

        void Delete(int Id);
    }
}
