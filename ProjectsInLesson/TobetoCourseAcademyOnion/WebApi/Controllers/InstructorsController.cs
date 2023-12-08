using Application.Features.Instructors.Commands.Create;
using Application.Features.Instructors.Commands.Delete;
using Application.Features.Instructors.Commands.Update;
using Application.Features.Instructors.Queries.GetById;
using Application.Features.Instructors.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        IMediator _mediator;
        public InstructorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateInstructorCommand createInstructorCommand)
        {
            CreatedInstructorResponse response = await _mediator.Send(createInstructorCommand);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateInstructorCommand updateInstructorCommand)
        {
            UpdatedInstructorResponse response = await _mediator.Send(updateInstructorCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeletedInstructorResponse response = await _mediator.Send(new DeleteInstructorCommand(id));
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdInstructorResponse response = await _mediator.Send(new GetByIdInstructorQuery(id));
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var response = await _mediator.Send(new GetListInstructorQuery());
            return Ok(response);
        }
    }
}
