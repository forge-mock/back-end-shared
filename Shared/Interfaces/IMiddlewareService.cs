using Microsoft.AspNetCore.Http;

namespace Shared.Interfaces;

public interface IMiddlewareService
{
    public void ConfigureHeaders(ref HttpContext context);
}