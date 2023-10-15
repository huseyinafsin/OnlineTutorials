using AutoMapper;
using BrightAkademi.Business.Abstract;
using BrightAkademi.Data.Abstract;
using BrightAkademi.Entity.Concrete;
using BrightAkademi.Shared.DTOs;
using BrightAkademi.Shared.ResponseDTOs;

namespace BrightAkademi.Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public TeacherManager(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public async Task<Response<TeacherDto>> CreateAsync(TeacherCreateDto teacherCreateDto)
        {
            var result = _mapper.Map<Teacher>(teacherCreateDto);
            result.User = new User
            {
                Username = result.FirstName.ToLower() + result.LastName.ToLower(),
                Password = result.FirstName.ToLower() + result.LastName.ToLower(),
                IsActive=true
            };
            await _teacherRepository.CreateAsync(result);
            return Response<TeacherDto>.Success(_mapper.Map<TeacherDto>(result), 201);
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var deletedCategory = await _teacherRepository.GetByIdAsync(id);
            if (deletedCategory == null)
            {
                return Response<NoContent>.Fail("Böyle bir öğretmen yok", 401);
            }
            _teacherRepository.Delete(deletedCategory);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<List<TeacherDto>>> GetAllAsync()
        {
            var teacherList = await _teacherRepository.GetAllAsync();
            if (teacherList == null)
            {
                return Response<List<TeacherDto>>.Fail("Hiç öğretmen bulunamadı", 301);
            }
            var teacherDtoList = _mapper.Map<List<TeacherDto>>(teacherList);
            return Response<List<TeacherDto>>.Success(teacherDtoList, 200);
        }

        public async Task<Response<TeacherDto>> GetByIdAsync(int id)
        {
            var teacher = await _teacherRepository.GetByIdAsync(id);
            if (teacher == null)
            {
                return Response<TeacherDto>.Fail("Böyle bir öğretmen yok!", 301);
            }
            var teacherDto = _mapper.Map<TeacherDto>(teacher);
            return Response<TeacherDto>.Success(teacherDto, 200);
        }

        public Task<int> TeacherCount()
        {
            return _teacherRepository.TeacherCount();
        }

        public async Task<Response<NoContent>> UpdateAsync(TeacherUpdateDto teacherUpdateDto)
        {
            var isThere = await _teacherRepository.AnyAsync(teacherUpdateDto.Id);
            if (isThere)
            {
                var category = _mapper.Map<Teacher>(teacherUpdateDto);
                category.ModifiedDate = DateTime.Now;
                _teacherRepository.Update(category);
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Böyle bir öğretmen bulunamadı", 401);
        }
    }
}