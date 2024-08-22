namespace KVKarco.CommonTypes;

public interface IValidator
{
    public PropertyError Validate(string propertyName);
}
