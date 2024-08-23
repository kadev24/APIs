using Newtonsoft.Json;
using Ventas.WebAPI.Models;

namespace Ventas.WebAPI
{
    public class ResponseFormatterMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseFormatterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);

            if (context.Response.StatusCode == StatusCodes.Status403Forbidden)
            {
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(
                    JsonConvert.SerializeObject(new ResponseModel(401, "Usted no tiene autorización de este recurso")));
            }
        }
    }
}
