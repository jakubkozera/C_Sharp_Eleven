namespace GenericAttributes
{
    public class EqualsAttribute<T> : Attribute
    {
        public EqualsAttribute(T value)
        {
            Value = value;
        }
        public T Value { get; set; }
    }

    public class Person
    {
        [EqualsAttribute<string>("Jakub")]
        public string Name { get; set; } = default!;

        [EqualsAttribute<int>(1)]
        public int Score { get; set; }
    }
}