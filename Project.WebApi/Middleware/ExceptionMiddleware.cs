
namespace Project.WebApi.Middleware
{
	public class ExceptionMiddleware : IMiddleware
	{
		public async Task InvokeAsync(HttpContext context, RequestDelegate next)
		{
			try
			{
				await next(context);
			}
			catch (Exception ex)
			{
				await HandleExceptionAsync(context, ex);
			}
		}

		public Task HandleExceptionAsync(HttpContext context, Exception ex)
		{
			context.Response.ContentType = "application/json";
			context.Response.StatusCode = (int)StatusCodes.Status500InternalServerError;

			return context.Response.WriteAsync(new ErrorResult
			{
				Message = ex.Message,
				StatusCode = context.Response.StatusCode
			}.ToString());
		}
	}
}
