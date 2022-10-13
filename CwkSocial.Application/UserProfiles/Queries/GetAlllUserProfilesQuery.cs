using CwkSocial.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace CwkSocial.Application.UserProfiles.Queries
{
    public class GetAlllUserProfilesQuery : IRequest<IEnumerable<UserProfile>>
    {
    }
}
