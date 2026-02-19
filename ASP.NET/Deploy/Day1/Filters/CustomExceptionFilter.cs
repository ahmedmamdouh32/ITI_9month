using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Day1.Filters
{
    public class CustomExceptionFilter : Attribute,IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            ViewResult view = new ViewResult();
            view.ViewName= "UserExceptionView";
            context.Result = view;
        }
    }
}
