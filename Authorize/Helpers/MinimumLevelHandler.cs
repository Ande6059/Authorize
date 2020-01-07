using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Authorize.Helpers
{
    public class MinimumLevelHandler : AuthorizationHandler<MinimumLevelRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumLevelRequirement requirement)
        {
            var level = context.User.FindFirst(c => c.Type == ClaimTypes.Level).Value;
            throw new NotImplementedException();

            var userLevel = User.Level;

            if (userLevel >= requirement.MinimumLevel) context.Succeed(requirement);


            return Task.CompletedTask;
        }
    }
}
