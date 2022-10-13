using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CwkSocial.Application.UserProfiles.Queries;
using CwkSocial.Dal;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CwkSocial.Application.UserProfiles.QueryHandler
{
    internal class GetAllUserProfilesQueryHandler : IRequestHandler<GetAlllUserProfilesQuery, IEnumerable<UserProfile>>
    {
        private readonly DataContext _ctx;

        public GetAllUserProfilesQueryHandler(DataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<UserProfile>> Handle(GetAlllUserProfilesQuery request, CancellationToken cancellationToken)
        {
            var profiles = await _ctx.UserProfiles.ToListAsync();

            return profiles;
        }
    }
}
