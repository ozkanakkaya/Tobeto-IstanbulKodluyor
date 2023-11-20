using Business.Abstracts;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseInstructorsController : ControllerBase
    {
        ICourseInstructorService _courseInstructorService;

        public CourseInstructorsController(ICourseInstructorService courseInstructorService)
        {
            _courseInstructorService = courseInstructorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _courseInstructorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _courseInstructorService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CourseInstructor courseInstructor)
        {
            var result = _courseInstructorService.Add(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CourseInstructor courseInstructor)
        {
            var result = _courseInstructorService.Delete(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CourseInstructor courseInstructor)
        {
            var result = _courseInstructorService.Update(courseInstructor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}