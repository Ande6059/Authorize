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
        public object User { get; private set; }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumLevelRequirement requirement)
        {
            var level = context.User.FindFirst(c => c.Type == ClaimTypes.Level).Value;


           
            var userLevel = User.Level;

            if (userLevel >= requirement.MinimumLevel) context.Succeed(requirement);


            return Task.CompletedTask;
        }
    }
}
