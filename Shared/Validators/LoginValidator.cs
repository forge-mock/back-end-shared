using FluentValidation;

namespace Shared.Validators;

public abstract class LoginValidator
{
    public static void AddUsernameRules<T>(IRuleBuilder<T, string> rule)
    {
        rule.NotEmpty().WithMessage("Username is required")
            .Matches("^[a-zA-Z0-9 ]{3,20}$")
            .WithMessage("Username must be 3-20 characters long and contain only letters and numbers");
    }

    public static void AddEmailRules<T>(IRuleBuilder<T, string> rule)
    {
        rule.NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Invalid email format");
    }

    public static void AddPasswordRules<T>(IRuleBuilder<T, string> rule)
    {
        rule.NotEmpty().WithMessage("Password is required")
            .Matches(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$")
            .WithMessage("Password must be at least 8 characters and contain letters & numbers");
    }
}