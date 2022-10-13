using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Dal;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.UserProfiles.CommandHandlers
{
    internal class UpdateUserProfileCommandHandler : IRequestHandler<UpdateUserProfileCommand>
    {
        private readonly DataContext _ctx;

        public UpdateUserProfileCommandHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<Unit> Handle(UpdateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var currentUserProfile = await _ctx.UserProfiles.FindAsync(request.Id);

            var currentBasicInfo = currentUserProfile.BasicInfo;

            var newBasicInfo = BasicInfo.Create(
                request.FirstName ?? currentBasicInfo.FirstName,
                request.LastName ?? currentBasicInfo.LastName,
                request.EmailAddress ?? currentBasicInfo.EmailAddress,
                request.Phone ?? currentBasicInfo.Phone,
                request.DateOfBirth ?? currentBasicInfo.DateOfBirth,
                request.CurrnetCity ?? currentBasicInfo.CurrnetCity
                );

            currentUserProfile.UpdateBasicInfo(newBasicInfo);

            await _ctx.SaveChangesAsync();

            return new Unit();
        }
    }
}
