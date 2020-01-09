using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorize.Helpers
{
    public class MinimumLevelRequirement : IAuthorizationRequirement
    {


        public object User { get; set; }
        public int MinimumLevel { get; set; }
        public MinimumLevelRequirement(int minimumLevel)
        {
            MinimumLevel = minimumLevel;
        }
    }
    
}
