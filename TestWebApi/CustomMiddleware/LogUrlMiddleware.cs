namespace TestWebApi.CustomMiddleware;

public class LogUrlMiddleware
{
    private RequestDelegate _requestDelegate;

    public LogUrlMiddleware(RequestDelegate requestDelegate)
    {
        _requestDelegate = requestDelegate;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine($"Log request: {context.Request}");
        await this._requestDelegate(context);
    }
}

public static class LogUrlExstensions
{
    public static IApplicationBuilder UseLogUrls(this IApplicationBuilder app)
    {
        return app.UseMiddleware<LogUrlMiddleware>();
    }
}