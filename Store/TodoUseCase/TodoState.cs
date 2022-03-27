using Fluxor;

[FeatureState]
public class TodoState
{
    public TodoState(List<TodoItem> todos)
    {
        Todos = todos;
    }

    private TodoState () {}

    public List<TodoItem> Todos { get; } = new();
}
