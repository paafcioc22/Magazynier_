﻿using AutoMapper;
using Magazynier.AplicationServices.API.Domain.Add;
using Magazynier.AplicationServices.ErrorHandling;
using Magazynier.DataAccess.CQRS;
using Magazynier.DataAccess.CQRS.Commands;
using Magazynier.DataAccess.Entities;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Magazynier.AplicationServices.API.Handlers.Add
{
    public class AddUserHandler : IRequestHandler<AddUserRequest, AddUserResponse>
    {
        private readonly IMapper mapper;
        private readonly ICommandExecutor commandExecutor;
        private readonly IPasswordHasher<User> passwordHasher;

        public AddUserHandler(IMapper mapper, ICommandExecutor commandExecutor, IPasswordHasher<User> passwordHasher)
        {
            this.mapper = mapper;
            this.commandExecutor = commandExecutor;
            this.passwordHasher = passwordHasher;
        }
        public async Task<AddUserResponse> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var user = this.mapper.Map<User>(request);

            if (user == null)
            {
                return new AddUserResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.UnsupportedMethod)
                };
            }

            var command = new AddUserCommand()
            {
                Parametr = user
            };

            command.Parametr.Password = passwordHasher.HashPassword(user, command.Parametr.Password);

            var userFromDb = await this.commandExecutor.Execute(command);

            if (userFromDb == null)
            {
                return new AddUserResponse()
                {
                    Error = new Domain.ErrorModel(ErrorType.NotFound)
                };
            }

            return new AddUserResponse()
            {
                Data = this.mapper.Map<Domain.Models.User>(userFromDb)
            };

        }


       
    }
}
