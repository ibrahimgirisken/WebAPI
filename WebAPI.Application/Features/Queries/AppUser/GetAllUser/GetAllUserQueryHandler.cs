using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Application.Abstractions.Services;

namespace WebAPI.Application.Features.Queries.AppUser.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
    {
        readonly IUserService _userService;

        public GetAllUserQueryHandler(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
        {
            var users=await _userService.GetAllUsersAsync(request.Page,request.Size);
            return new()
            {
                Users = users,
                TotalUsersCount =_userService.TotalUsersCount
            };
        }
    }
}
