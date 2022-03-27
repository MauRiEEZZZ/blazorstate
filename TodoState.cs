using System.Collections.ObjectModel;

public class TodoState
{
    public List<TodoItem> Todos { get; set; } = new();

    public int ItemsTodoCount { get { return Todos?.Count(x => !x.IsDone) ?? 0; }}
}