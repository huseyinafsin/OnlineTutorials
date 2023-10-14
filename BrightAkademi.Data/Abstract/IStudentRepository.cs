using BrightAkademi.Entity.Concrete;

namespace BrightAkademi.Data.Abstract
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<bool> AnyAsync(int id);
        Task<Student> GetByUserIdAsync(int id);
    }
}