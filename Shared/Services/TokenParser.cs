using System.IdentityModel.Tokens.Jwt;
using Shared.Interfaces;
using Shared.Models;

namespace Shared.Services;

public class TokenParser : ITokenParser
{
    public TokenInformation ParseToken(string authHeader)
    {
        string token = authHeader["Bearer ".Length..];

        JwtSecurityTokenHandler handler = new();
        JwtSecurityToken? jwtToken = handler.ReadJwtToken(token);

        Guid userId = Guid.Parse(ClaimValue(jwtToken, "sub"));
        string username = ClaimValue(jwtToken, "name");
        string userEmail = ClaimValue(jwtToken, "email");

        TokenInformation tokenInformation = new(userId, username, userEmail);

        return tokenInformation;
    }

    private static string ClaimValue(JwtSecurityToken jwtToken, string claimType)
    {
        return jwtToken.Claims.FirstOrDefault(c => c.Type == claimType)?.Value ?? string.Empty;
    }
}