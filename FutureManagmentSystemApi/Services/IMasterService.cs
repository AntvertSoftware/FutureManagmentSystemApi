using FutureManagmentSystemApi.Models.Bussiness;

namespace FutureManagmentSystemApi.Services
{
    public interface IMasterService<T>
    {
       Task< IEnumerable<T>> GetAll();
        Task AddData(T item);
        Task Update(T item);
        Task Delete(int Id);
    }
}
