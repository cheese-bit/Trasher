using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace trash.ActionFilter
{
    public class GlobalRouting : IActionFilter
    {
        private readonly ClaimsPrincipal _claimspPrincipal;
        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimspPrincipal = claimsPrincipal;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            if (controller.Equals("Home"))
            {
                if (_claimspPrincipal.IsInRole("Customer"))
                {
                    context.Result = new RedirectToActionResult("Index", "Customers", null);
                }
                else if (_claimspPrincipal.IsInRole("Employee"))
                {
                    context.Result = new RedirectToActionResult("Index", "Employees", null);
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }


    

    
}
