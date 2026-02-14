namespace UserManagementAPI.Middleware;

using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class RequestResponseLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestResponseLoggingMiddleware> _logger;

    public RequestResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestResponseLoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        // Log request
        _logger.LogInformation("Incoming Request: {method} {path}", context.Request.Method, context.Request.Path);

        await _next(context);

        // Log response
        _logger.LogInformation("Outgoing Response: {statusCode}", context.Response.StatusCode);
    }
}
