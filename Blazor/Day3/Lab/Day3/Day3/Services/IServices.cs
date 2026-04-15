namespace Day3.Services
{
    public interface IServices<T>
    {
        Task<List<T>> GetAll();

        Task<T> GetById(int id);
        Task Add(T entity);

        Task Update(int id, T entity);

        Task Delete(int id);
    }
}
