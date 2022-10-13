﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Dal;
using MediatR;

namespace CwkSocial.Application.UserProfiles.CommandHandlers
{
    internal class DeleteUserProfileCommandHandler : IRequestHandler<DeleteUserProfileCommand>
    {
        private readonly DataContext _ctx;

        public DeleteUserProfileCommandHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Unit> Handle(DeleteUserProfileCommand request, CancellationToken cancellationToken)
        {
            var userProfile = await _ctx.UserProfiles.FindAsync(request.Id);

            _ctx.UserProfiles.Remove(userProfile);

            await _ctx.SaveChangesAsync();

            return new Unit();
        }
    }
}
