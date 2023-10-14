﻿using BrightAkademi.Business.Abstract;
using BrightAkademi.Shared.ControllerBases;
using BrightAkademi.Shared.DTOs;
using BrightAkademi.Shared.ResponseDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.Json;

namespace BrightAkademi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomControllerBase
    {
        private readonly ICourseService _courseManager;
        private readonly IUserService _userService;
        private readonly IStudentService _studentService;

        public CoursesController(ICourseService courseManager, IUserService userService, IStudentService studentService)
        {
            _courseManager = courseManager;
            _userService = userService;
            _studentService = studentService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetCourses()
        {
            var response = await _courseManager.GetAllAsync();
            if (response.IsSucceeded)
            {
                //return new JsonResult(response);
                return Ok(response);
            }
            return NotFound();
        }      
        
        [HttpGet("studentCourses/{studentId}")]
        public async Task<IActionResult> GetStudentCourses(int studentId)
        {
            var response = await _courseManager.GetByStudentIdAsync(studentId);
            if (response.IsSucceeded)
            {
                //return new JsonResult(response);
                return Ok(response);
            }
            return NotFound();
        }    
        
        [HttpGet("myCourses")]
        [Authorize(Roles = "Trainees")]
        public async Task<IActionResult> GetMyCourses()
        {

            var username = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
           
            var user = _userService.GetByUsername(username).Result.Data;
            var student = _studentService.GetByIdAsync(user.Id).Result.Data;
            if (user != null)
            {
                var response =await _courseManager.GetByStudentIdAsync(student.Id);
                if (response.IsSucceeded)
                {
                    //return new JsonResult(response);
                    return Ok(response);
                }
            }
      
            return NotFound();
        }
               
        [HttpGet("teachercourses")]
        [Authorize(Roles = "Trainers")]
        public async Task<IActionResult> GetTeacherCourses()
        {

            var username = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
           
            var user = _userService.GetByUsername(username).Result.Data;
            var student = _studentService.GetByIdAsync(user.Id).Result.Data;
            if (user != null)
            {
                var response =await _courseManager.GetByStudentIdAsync(student.Id);
                if (response.IsSucceeded)
                {
                    //return new JsonResult(response);
                    return Ok(response);
                }
            }
      
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCourse(int id)
        {
            var response = await _courseManager.GetByIdAsync(id);
            if (response.IsSucceeded)
            {
                //var jsonResult = JsonSerializer.Serialize(response);
                return Ok(response);
            }
            return NotFound();
        }

        [HttpPost]
        [Authorize(Roles = "Super Admin,Admin")]
        public async Task<IActionResult> CreateCourse(CourseCreateDto courseCreateDto)
        {
            var response = await _courseManager.CreateAsync(courseCreateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpPut]
        [Authorize(Roles = "Super Admin,Admin")]
        public async Task<IActionResult> UpdateCourse(CourseUpdateDto courseUpdateDto)
        {
            var response = await _courseManager.UpdateAsync(courseUpdateDto);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }

        [HttpDelete]
        [Authorize(Roles = "Super Admin,Admin")]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var response = await _courseManager.DeleteAsync(id);
            if (response.IsSucceeded)
            {
                return CreateActionResult(response);
            }
            return BadRequest();
        }
    }
}