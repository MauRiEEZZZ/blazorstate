using Fluxor;

public static class Reducers
{
    [ReducerMethod]
    public static TodoState ReduceAddTodoItemAction(TodoState state, AddTodoItemAction action) 
    {
        state.Todos.Add(action.ItemToAdd);
        return new TodoState(todos: state.Todos);
    }
}