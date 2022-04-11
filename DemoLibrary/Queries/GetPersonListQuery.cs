using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries;

// Records are the same as classes but they include some syntax sugar, they are pretty much read-only
public record GetPersonListQuery() : IRequest<List<PersonModel>>;

// This is the same as the record above minus the immutability.
// public record GetPersonListQueryClass(): IRequest<List<PersonModel>>;
// {
// }
