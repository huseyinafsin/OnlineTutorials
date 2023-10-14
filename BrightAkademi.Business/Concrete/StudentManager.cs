using AutoMapper;
using BrightAkademi.Business.Abstract;
using BrightAkademi.Data.Abstract;
using BrightAkademi.Entity.Concrete;
using BrightAkademi.Shared.DTOs;
using BrightAkademi.Shared.ResponseDTOs;

namespace BrightAkademi.Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentManager(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<Response<StudentDto>> CreateAsync(StudentCreateDto studentCreateDto)
        {
            var result = _mapper.Map<Student>(studentCreateDto);
            result.User = new User
            {
                Username = result.FirstName.ToLower() + result.LastName.ToLower(),
                Password = result.FirstName.ToLower() + result.LastName.ToLower()
            };
            await _studentRepository.CreateAsync(result);
            return Response<StudentDto>.Success(_mapper.Map<StudentDto>(result), 201);
        }

        public async Task<Response<NoContent>> DeleteAsync(int id)
        {
            var deletedStudent = await _studentRepository.GetByIdAsync(id);
            if (deletedStudent == null)
            {
                return Response<NoContent>.Fail("Böyle bir öğrenci yok", 401);
            }
            _studentRepository.Delete(deletedStudent);
            return Response<NoContent>.Success(200);
        }

        public async Task<Response<List<StudentDto>>> GetAllAsync()
        {
            var studentList = await _studentRepository.GetAllAsync();
            if (studentList == null)
            {
                return Response<List<StudentDto>>.Fail("Hiç öğrenci bulunamadı", 301);
            }
            var studentDtoList = _mapper.Map<List<StudentDto>>(studentList);
            return Response<List<StudentDto>>.Success(studentDtoList, 200);
        }

        public async Task<Response<List<StudentDto>>> GetByCourseIdAsync(int courseId)
        {
            var students = await _studentRepository.GetByCourseIdAsync(courseId);
            if (students == null)
            {
                return Response<List<StudentDto>>.Fail("Böyle bir öğrenci yok!", 301);
            }
            var studentDto = _mapper.Map<List<StudentDto>>(students);
            return Response<List<StudentDto>>.Success(studentDto, 200);
        }

        public async Task<Response<StudentDto>> GetByIdAsync(int id)
        {
            var student = await _studentRepository.GetByIdAsync(id);
            if (student == null)
            {
                return Response<StudentDto>.Fail("Böyle bir öğrenci yok!", 301);
            }
            var studentDto = _mapper.Map<StudentDto>(student);
            return Response<StudentDto>.Success(studentDto, 200);
        }

        public async Task<Response<StudentDto>> GetByUserIdAsync(int id)
        {
            var student = await _studentRepository.GetByUserIdAsync(id);
            if (student == null)
            {
                return Response<StudentDto>.Fail("Böyle bir öğrenci yok!", 301);
            }
            var studentDto = _mapper.Map<StudentDto>(student);
            return Response<StudentDto>.Success(studentDto, 200);
        }

        public async Task<Response<NoContent>> UpdateAsync(StudentUpdateDto studentUpdateDto)
        {
            var isThere = await _studentRepository.AnyAsync(studentUpdateDto.Id);
            if (isThere)
            {
                var student = _mapper.Map<Student>(studentUpdateDto);
                student.ModifiedDate = DateTime.Now;
                _studentRepository.Update(student);
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Böyle bir öğrenci bulunamadı", 401);
        }


    }
}