namespace Shared.Models;

public sealed class User
{
    public Guid Id { get; set; }

    public string Username { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string? Password { get; set; }

    public DateTime CreatedDate { get; set; }

    public ICollection<Token> Tokens { get; set; } = new List<Token>();

    public ICollection<UserOauthProvider> UserOauthProviders { get; set; } = new List<UserOauthProvider>();
}