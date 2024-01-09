using MediatR;
namespace CleanArchitecture.Application;

public sealed record CreateUserRequest(string Email, string Name) : IRequest<CreateUserResponse>;
