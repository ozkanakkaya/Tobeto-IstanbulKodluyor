using Application.Features.Categories.Commands.Create;
using Application.Features.Categories.Commands.Delete;
using Application.Features.Categories.Commands.Update;
using Application.Features.Categories.Queries.GetById;
using Application.Features.Categories.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        IMediator _mediator;
        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            CreatedCategoryResponse response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryCommand updateCategoryCommand)
        {
            UpdatedCategoryResponse response = await _mediator.Send(updateCategoryCommand);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            DeletedCategoryResponse response = await _mediator.Send(new DeleteCategoryCommand(id));
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetByIdCategoryResponse response = await _mediator.Send(new GetByIdCategoryQuery(id));
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var response = await _mediator.Send(new GetListCategoryQuery());
            return Ok(response);
        }
    }
}
