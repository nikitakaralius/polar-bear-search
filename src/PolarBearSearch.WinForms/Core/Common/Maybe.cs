namespace Core.Common;

public readonly record struct Maybe<T>(T _value, bool HasValue = true)
{
    public static readonly Maybe<T> Nothing = new();

    private readonly T _value = _value;

    public bool HasValue { get; } = HasValue;
    
    public bool IsNothing => HasValue == false;

    public T Value
    {
        get
        {
            if (IsNothing)
            {
                throw new NothingValueException();
            }
            return _value;
        }
    }
}