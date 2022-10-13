using AutoMapper;
using CwkSocial.Api.Contracts.UserProfile.Requests;
using CwkSocial.Api.Contracts.UserProfile.Responses;
using CwkSocial.Application.UserProfiles.Commands;
using CwkSocial.Application.UserProfiles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CwkSocial.Api.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route(ApiRoutes.BaseRoute)]
    [ApiController]
    public class UserProfilesController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserProfilesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _mediator.Send(new GetAlllUserProfilesQuery());

            var profiles = _mapper.Map<IEnumerable<UserProfileResponse>>(response);

            return Ok(profiles);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserProfileCreateRequest userProfileCreate)
        {
            var command = _mapper.Map<CreateUserProfileCommand>(userProfileCreate);

            var response = await _mediator.Send(command);

            var result = _mapper.Map<UserProfileResponse>(response);

            return CreatedAtAction(nameof(GetById), new { id = response.Id }, result);
        }

        [HttpGet]
        [Route(ApiRoutes.UserProfiles.IdRoute)]
        public async Task<IActionResult> GetById(string id)
        {
            var query = new GetUserProfileByIdQuery
            {
                Id = Guid.Parse(id)
            };

            var response = await _mediator.Send(query);

            var result = _mapper.Map<UserProfileResponse>(response);

            return Ok(result);
        }

        [HttpPatch]
        [Route(ApiRoutes.UserProfiles.IdRoute)]
        public async Task<IActionResult> Update(string id, [FromBody] UserProfileUpdateRequest userProfileUpdate)
        {
            var command = _mapper.Map<UpdateUserProfileCommand>(userProfileUpdate);
            command.Id = Guid.Parse(id);

            _ = await _mediator.Send(command);

            return NoContent();
        }

        [HttpDelete]
        [Route(ApiRoutes.UserProfiles.IdRoute)]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteUserProfileCommand
            {
                Id = Guid.Parse(id)
            };

            _ = await _mediator.Send(command);

            return NoContent();
        }
    }
}
