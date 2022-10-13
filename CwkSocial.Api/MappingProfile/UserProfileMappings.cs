using AutoMapper;
using CwkSocial.Api.Contracts.UserProfile.Requests;
using CwkSocial.Api.Contracts.UserProfile.Responses;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Api.MappingProfile
{
    public class UserProfileMappings : Profile
    {
        public UserProfileMappings()
        {
            CreateMap<UserProfileCreateRequest, CreateUserProfileCommand>();

            CreateMap<UserProfile, UserProfileResponse>();

            CreateMap<BasicInfo, BasicInfoResponse>();

            CreateMap<UserProfileUpdateRequest, UpdateUserProfileCommand>();
        }
    }
}
