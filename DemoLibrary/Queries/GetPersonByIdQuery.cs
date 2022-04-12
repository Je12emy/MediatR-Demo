using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries;

public record GetPersonByIdQuery(int id) : IRequest<PersonModel>;

// public class GetPersonByIdClass : IRequest<PersonModel>
// {
//     public int Id { get; set; }
//
//     public GetPersonByIdClass(int id)
//     {
//         Id = id;
//     }
// }
