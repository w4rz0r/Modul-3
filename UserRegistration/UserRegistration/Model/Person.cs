namespace UserRegistration.Model
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }


        public Person()
        {
        }

        public Person(string firstName, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            Email = email;
        }
    }
}
