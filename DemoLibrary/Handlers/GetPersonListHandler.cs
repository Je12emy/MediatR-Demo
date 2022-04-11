using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;

namespace DemoLibrary.Handlers;

// <Query type we handle, Return type>
public class GetPersonListHandler : IRequestHandler<GetPersonListQuery, List<PersonModel>>
{
    private readonly IDemoDataAccess _data;

    public GetPersonListHandler(IDemoDataAccess data)
    {
        _data = data;
    }
    // The handle method
    public Task<List<PersonModel>> Handle(GetPersonListQuery request, CancellationToken cancellationToken)
    {
        // Wrap the synchronous result in a completed task
        return Task.FromResult(_data.GetPeople());
    }
}
