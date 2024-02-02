using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Application.Features.Commands.AppUser.RefreshTokenToUser
{
    public class RefreshTokenToUserCommandHandler : IRequestHandler<RefreshTokenToUserCommandRequest, RefreshTokenToUserCommandResponse>
    {
        public Task<RefreshTokenToUserCommandResponse> Handle(RefreshTokenToUserCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
