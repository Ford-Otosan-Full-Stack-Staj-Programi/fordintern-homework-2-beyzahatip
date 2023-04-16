using Homework2.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Homework2
{
    public class FilterByAccountId : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var httpContext = context.HttpContext;
            var accountId = httpContext.Session.GetInt32("AccountId");

            if (!accountId.HasValue)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
                return;
            }

            
            context.RouteData.Values.Add("AccountId", accountId.Value);

            base.OnActionExecuting(context);
        }
    }
}
