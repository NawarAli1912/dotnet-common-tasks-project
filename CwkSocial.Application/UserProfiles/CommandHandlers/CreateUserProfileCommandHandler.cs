using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Dal;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.UserProfiles.CommandHandlers
{
    public class CreateUserProfileCommandHandler : IRequestHandler<CreateUserProfileCommand, UserProfile>
    {
        private readonly DataContext _ctx;
        private readonly IMapper _mapper;

        public CreateUserProfileCommandHandler(DataContext ctx, IMapper mapper)
        {
            _ctx = ctx;
            _mapper = mapper;
        }

        public async Task<UserProfile> Handle(CreateUserProfileCommand request, CancellationToken cancellationToken)
        {
            var basicInfo = BasicInfo.Create(
                request.FirstName,
                request.LastName,
                request.EmailAddress, 
                request.Phone,
                request.DateOfBirth,
                request.CurrnetCity);

            var userProfile = UserProfile.Create(Guid.NewGuid().ToString(), basicInfo);

            _ctx.UserProfiles.Add(userProfile);

            await _ctx.SaveChangesAsync();
            return userProfile;
        }
    }
}
