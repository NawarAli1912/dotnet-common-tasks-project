using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CwkSocial.Application.UserProfiles.Commands
{
    public class DeleteUserProfileCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
