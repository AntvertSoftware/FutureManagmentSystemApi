using FutureManagmentSystemApi.DataBase;
using Microsoft.EntityFrameworkCore;

namespace FutureManagmentSystemApi.Services
{
    public class MasterService<T> : IMasterService<T> where T : class
    {
        private readonly ContextClass context;
        private DbSet<T> Table = null;

        public MasterService(ContextClass context)
        {
            this.context = context;
            Table = context.Set<T>();
        }

        public async Task AddData(T item)
        {
            try
            {
                if(item == null)
                {
                    throw new ArgumentNullException("Data can't be null");
                }
               await Table.AddAsync(item);
                await context.SaveChangesAsync();
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Delete(int Id)
        {
            try
            {
                var result = Table.Find(Id);
                if (Id == null)
                {
                    throw new ArgumentNullException("Data can't be null");
                }

                 context.Remove(result);
                await context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            try
            {
              var result= await Table.ToListAsync();
                return result;
            
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
