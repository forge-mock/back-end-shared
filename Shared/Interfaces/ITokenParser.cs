using Shared.Models;

namespace Shared.Interfaces;

public interface ITokenParser
{
    public TokenInformation ParseToken(string authHeader);
}