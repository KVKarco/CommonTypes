using System.Collections.ObjectModel;

namespace KVKarco.CommonTypes;

public readonly record struct PropertyError
{
    private PropertyError(string propertyName)
    {
        if (!string.IsNullOrWhiteSpace(propertyName))
        {
            throw new InvalidOperationException("propertyName is required.");
        }
        PropertyName = propertyName;
        ErrorMessages = [];
    }
    public static PropertyError Create(string propertyName) => new(propertyName);

    public string PropertyName { get; }
    public Collection<string> ErrorMessages { get; }

    public void AddMessage(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            return;
        }

        if (ErrorMessages.Contains(message, StringComparer.OrdinalIgnoreCase))
        {
            return;
        }

        ErrorMessages.Add(message);
        return;
    }
}
