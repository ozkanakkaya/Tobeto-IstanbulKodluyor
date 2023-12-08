using Application.Features.CourseInstructors.Commands.Create;
using Application.Features.CourseInstructors.Commands.Delete;
using Application.Features.CourseInstructors.Commands.Update;
using Application.Features.CourseInstructors.Queries.GetById;
using Application.Features.CourseInstructors.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseInstructorsController : ControllerBase
    {
        IMediator _mediator;
        public CourseInstructorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCourseInstructorCommand createCourseInstructorCommand)
        {
            CreatedCourseInstructorResponse response = await _mediator.Send(createCourseInstructorCommand);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCourseInstructorCommand updateCourseInstructorCommand)
        {
            UpdatedCourseInstructorResponse response = await _mediator.Send(updateCourseInstructorCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeletedCourseInstructorResponse response = await _mediator.Send(new DeleteCourseInstructorCommand(id));
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdCourseInstructorResponse response = await _mediator.Send(new GetByIdCourseInstructorQuery(id));
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var response = await _mediator.Send(new GetListCourseInstructorQuery());
            return Ok(response);
        }
    }
}
