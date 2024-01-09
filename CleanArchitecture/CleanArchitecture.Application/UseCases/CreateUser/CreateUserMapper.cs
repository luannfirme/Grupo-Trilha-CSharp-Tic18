using AutoMapper;
using CleanArchitecture.Domain.Entities;
using MediatR;
namespace CleanArchitecture.Application;

public sealed class CreateUserMapper : Profile
{
    public CreateUserMapper()
    {
        CreateMap<CreateUserRequest, User>();
        CreateMap<User, CreateUserResponse>();
    }
}
