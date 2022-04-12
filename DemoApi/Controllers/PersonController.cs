using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : Controller
{
    private readonly IMediator _mediator;

    public PersonController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<List<PersonModel>> Get()
    {
        return await _mediator.Send(new GetPersonListQuery());
    }

    [HttpGet("{id}")]
    public async Task<PersonModel> Get(int id)
    {
        return await _mediator.Send(new GetPersonByIdQuery(id));
    }

    [HttpPost]
    public async Task<PersonModel> Post([FromBody] PersonModel value)
    {
        var person = await _mediator.Send(new InsertPersonCommand(value.FirstName, value.LastName));
        return person;
    }
}
