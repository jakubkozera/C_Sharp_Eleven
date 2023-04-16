namespace RequiredMembers
{
    public class Person
    {

        public  string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public required string LastName { get; set; }
    }
}