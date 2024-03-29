﻿using Application.Dtos.Users;
using Domain.Models;
using MediatR;

namespace Application.Commands.Users.Register
{
    public class RegisterUserCommand : IRequest<User>
    {
        public RegisterUserCommand(UserCredentialsDto newUser)
        {
            NewUser = newUser;
        }

        public UserCredentialsDto NewUser { get; }
    }
}