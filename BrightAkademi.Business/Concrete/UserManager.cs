using AutoMapper;
using BrightAkademi.Business.Abstract;
using BrightAkademi.Data.Abstract;
using BrightAkademi.Entity.Concrete;
using BrightAkademi.Shared.DTOs;
using BrightAkademi.Shared.ResponseDTOs;

namespace BrightAkademi.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserRoleRepository _userRoleRepository;
        private readonly IMapper _mapper;

        public UserManager(IMapper mapper, IUserRoleRepository userRoleRepository, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRoleRepository = userRoleRepository;
            _userRepository = userRepository;
        }

        public async Task<Response<UserDto>> CreateAsync(UserCreateDto userCreateDto)
        {
            var newUser = _mapper.Map<User>(userCreateDto);
            await _userRepository.CreateAsync(newUser);
            return Response<UserDto>.Success(_mapper.Map<UserDto>(newUser), 201);
        }

        public Task<Response<NoContent>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<UserDto>>> GetAllAsync()
        {
            var levelList = await _userRepository.GetAllAsync();
            if (levelList == null)
            {
                return Response<List<UserDto>>.Fail("Hiç seviye bulunamadı", 301);
            }
            var userDtoList = _mapper.Map<List<UserDto>>(levelList);
            return Response<List<UserDto>>.Success(userDtoList, 200);
        }

        public async Task<Response<UserDto>> GetByIdAsync(int id)
        {
            var level = await _userRepository.GetByIdAsync(id);
            if (level == null)
            {
                return Response<UserDto>.Fail("Böyle bir seviye yok!", 301);
            }
            var levelDto = _mapper.Map<UserDto>(level);
            return Response<UserDto>.Success(levelDto, 200);
        }

        public async Task<Response<UserDto>> GetByUsername(string username)
        {
            var user =await _userRepository.GetByUsernameAsync(username);
            if (user == null)
            {
                return Response<UserDto>.Fail("Böyle bir seviye yok!", 301);
            }
            var userDto = _mapper.Map<UserDto>(user);
            return Response<UserDto>.Success(userDto, 200);
        }

        public async Task<Response<List<UserRole>>> GetUserRoles(int userId)
        {
            var userRoles =await _userRoleRepository.GetUserRoles(userId);
            return Response<List<UserRole>>.Success(userRoles, 200);
        }

        public async Task<Response<NoContent>> UpdateAsync(UserUpdateDto userUpdateDto)
        {
            var isThere = await _userRepository.GetByIdAsync(userUpdateDto.Id);
            if (isThere != null)
            {
                var user = _mapper.Map<User>(userUpdateDto);
                user.ModifiedDate = DateTime.Now;
                _userRepository.Update(user);
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Böyle bir seviye bulunamadı", 401);
        }


    }
}
