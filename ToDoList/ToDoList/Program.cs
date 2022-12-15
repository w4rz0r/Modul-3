using ToDoList.Model;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();


var Json = File.ReadAllText("todos.Json");
var todos = JsonSerializer.Deserialize<List<ToDo>>(Json);

app.MapGet("/todo/{id}", (Guid id) =>
{
    return todos.SingleOrDefault(t => t.Id == id);
});

app.MapGet("/todo", () =>
{
    return todos;
});

app.MapPut("/todo", async (ToDo todo) =>
{
    var todoInList = todos.SingleOrDefault(todos => todos.Id == todo.Id);
    todoInList.DoneDate = DateTime.Today;
    var Json = JsonSerializer.Serialize(todos);
    await File.WriteAllTextAsync("todos.Json", Json);
});

app.MapPost("/todo", async (ToDo todo) =>
{
    todos.Add(todo);
    var Json = JsonSerializer.Serialize(todos);
    await File.WriteAllTextAsync("todos.Json", Json);
});
app.Run();