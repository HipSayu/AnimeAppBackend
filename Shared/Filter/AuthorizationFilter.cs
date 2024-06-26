using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiBasic.Shared.Constant;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiBasic.Shared.Filter
{
    public class AuthorizationFilter : Attribute, IAuthorizationFilter
    {
        private readonly int[] _userTypes;

        public AuthorizationFilter(params int[] userTypes)
        {
            _userTypes = userTypes;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //
            var user = context.HttpContext.User;
            var claims = user.Claims.ToList();
            //if else
            var userTypeClaim = claims.FirstOrDefault(c => c.Type == CustomClaimTypes.UserType);
            if (userTypeClaim != null)
            {
                int userType = int.Parse(userTypeClaim.Value);
                if (!_userTypes.Contains(userType))
                {
                    context.Result = new UnauthorizedObjectResult(
                        new { message = $"User type = {userType} không có quyền" }
                    );
                }
            }
            else
            {
                context.Result = new UnauthorizedObjectResult(new { message = $"Không có quyền" });
            }
        }
    }
}