// See https://aka.ms/new-console-template for more information
using GenericAttributes;
using System.Reflection;

Console.WriteLine("Hello, World!");

var person = new Person()
{
    Name = "Jakub",
    Score = 10
};

Validate(person);

void Validate(Person person)
{
    var props = typeof(Person).GetProperties();
    foreach (var prop in props)
    {
        var propValue = prop.GetValue(person);

        var propType = prop.PropertyType;

        var equalsAttribute = prop.GetCustomAttribute(typeof(EqualsAttribute<>));

        if (equalsAttribute is not null && propValue is not null)
        {
            var equalsAttributeType = equalsAttribute.GetType().GetGenericArguments()[0];
            if (equalsAttributeType == typeof(string))
            {
                var attributeValue = ((EqualsAttribute<string>)equalsAttribute).Value;
                if (attributeValue != (string)propValue)
                {
                    throw new Exception($"Field {prop.Name} with value {propValue} != {attributeValue}");
                }
            }
            if (equalsAttributeType == typeof(int))
            {
                var attributeValue = ((EqualsAttribute<int>)equalsAttribute).Value;
                if (attributeValue != (int)propValue)
                {
                    throw new Exception($"Field {prop.Name} with value {propValue} != {attributeValue}");
                }
            }
        }
    }
}