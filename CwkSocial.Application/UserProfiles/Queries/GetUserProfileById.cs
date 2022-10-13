using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.UserProfiles.Queries
{
    public class GetUserProfileByIdQuery : IRequest<UserProfile>
    {
        public Guid Id { get; set; }
    }
}
