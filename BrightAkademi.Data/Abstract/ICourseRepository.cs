using BrightAkademi.Shared.DTOs;
using BrightWeb.Entity.Concrete;

namespace BrightAkademi.Data.Abstract
{
    public interface ICourseRepository : IGenericRepository<Course>
    {
        Task<bool> AnyAsync(int id);
        Task<List<Course>> GetByStudentIdAsync(int studentId);
        Task<List<Course>> GetByTeacherId(int teacherId);
        Task<List<Course>> GetCoursesWithDetail(int? categoryId);
    }
}