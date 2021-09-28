using br.com.paype.Models.TI;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace br.com.paype
{
    public class AgeRequirementHandler: AuthorizationHandler<AgeRequirement>
    {

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AgeRequirement requirement)
        {


            if (!context.User.HasClaim(claim => claim.Type == "age"))
            {
                return Task.CompletedTask;
            }

            if (!int.TryParse(context.User.FindFirst(c => c.Type == "age").Value, out int actualAge))
            {
                return Task.CompletedTask;
            }

            if(actualAge > requirement.Age)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;

        }
    }

}
