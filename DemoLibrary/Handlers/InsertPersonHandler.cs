using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Handlers;

public class InsertPersonHandler : IRequestHandler<InsertPersonCommand, PersonModel>
{
    private readonly IDemoDataAccess _data;

    public InsertPersonHandler(IDemoDataAccess data)
    {
        _data = data;
    }
    public Task<PersonModel> Handle(InsertPersonCommand request, CancellationToken cancellationToken)
    {
        var person = _data.InsertPerson(request.FirstName, request.LastName);
        return Task.FromResult(person);
    }
}
