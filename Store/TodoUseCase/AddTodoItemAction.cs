public class AddTodoItemAction
{
    public AddTodoItemAction(TodoItem itemToAdd)
    {
        ItemToAdd = itemToAdd;
    }

    public TodoItem ItemToAdd { get; }
}
