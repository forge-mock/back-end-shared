namespace Shared.Models;

public sealed class Token
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime ExpirationDate { get; set; }

    public Guid UserId { get; set; }

    public User User { get; set; } = null!;
}

public sealed class TokenInformation(Guid id, string username, string userEmail)
{
    public Guid Id { get; init; } = id;

    public string Username { get; init; } = username;

    public string UserEmail { get; init; } = userEmail;
}