namespace ToDoList.Model
{
    public class ToDo
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public DateTime? DoneDate { get; set; }

        public ToDo()
        {
            Id = Guid.NewGuid();
        }
        public ToDo(string text)
        {
            Text = text;
        }
    }
}
