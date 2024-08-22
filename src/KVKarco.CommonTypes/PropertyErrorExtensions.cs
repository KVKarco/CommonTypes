namespace KVKarco.CommonTypes;

public static class PropertyErrorExtensions
{
    public static void StringIsNullOrWhiteSpace(this PropertyError error, string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            error.AddMessage("Cant be null, empty or white space.");
        }
    }

    public static void StringMinLength(this PropertyError error, string value, int minLength)
    {
        if (!string.IsNullOrWhiteSpace(value) && value.Length < minLength)
        {
            error.AddMessage($"Cant be less then {minLength} characters.");
        }
    }

    public static void StringMaxLength(this PropertyError error, string value, int maxLength)
    {
        if (!string.IsNullOrWhiteSpace(value) && value.Length > maxLength)
        {
            error.AddMessage($"Cant be more then {maxLength} characters.");
        }
    }

    public static void StringIsEmail(this PropertyError error, string value)
    {
        if (!string.IsNullOrWhiteSpace(value) && !value.Contains('@', StringComparison.Ordinal))
        {
            error.AddMessage($"Must contain @ symbol.");
        }
    }
}
