using UserRegistration.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

var people = new List<Person>
{
        new Person ("Per", "per@mail.com"),
        new Person ("Pål", "pål@mail.com"),
        new Person ("Espen", "espen@mail.com"),
        new Person ("Terje", "Terje@mail.com"),
};


app.MapGet("/people", () =>
{
    return people;
});
app.MapDelete("/people/{id}", (Guid id) =>
{
    people = people.Where(p => p.Id != id).ToList();
});
app.Run();