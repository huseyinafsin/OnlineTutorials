using BrightAkademi.Data.Abstract;
using BrightAkademi.Data.Concrete.EfCore.Contexts;
using BrightAkademi.Shared.DTOs;
using BrightWeb.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BrightAkademi.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCourseRepository : EfCoreGenericRepository<Course>, ICourseRepository
    {
        private readonly BrightAkademiContext _context;
        public EfCoreCourseRepository(BrightAkademiContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await _context
                .Categories
                .AnyAsync(x => x.Id == id);
        }

        public async Task<List<Course>> GetByStudentIdAsync(int studentId)
        {

            return await _context.Courses.Include(x => x.CourseStudents).Where(w => w.CourseStudents.Select(s=>s.StudentId).Contains(studentId)).ToListAsync();
        }
    }
}