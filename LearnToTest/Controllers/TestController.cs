using LearnToTest.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LearnToTest.Controllers;

[ApiController]
[Route("/api/test")]
public class TestController: ControllerBase
{
    private readonly IMediator _mediator;

    public TestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var command = new TestCommand()
        {
            Name = "Hello World"
        };
        var response = await _mediator.Send(command);
        return Ok(response);
    }
    
}