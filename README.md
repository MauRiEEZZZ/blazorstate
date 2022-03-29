# Blazorstate

Here I have several different implementations of patterns for managing state in Blazor.

Nick Chapsas explains in [this video](https://www.youtube.com/watch?v=k_c-ErPaYa8) how state can be managed using Fluxor. However everything works on each page the implementation is fairly simple. Maybe too simple to be of real value, it leaves out a lot of implemetation of how to handle more complex objects.

I have implemented fluxor on the TodoPage where a collection of TodoItems are managed. See the fluxor branch to test this out.

## otherways to victory

[Microsoft docs](https://docs.microsoft.com/en-us/aspnet/core/blazor/state-management?view=aspnetcore-6.0&pivots=server) pages describe otherways to manage your state. Among these solutions is the [In-memory state container service](https://docs.microsoft.com/en-us/aspnet/core/blazor/state-management?view=aspnetcore-6.0&pivots=server#in-memory-state-container-service-server) I have implemented this solution in the statecontainer branch.

## current conclusion

While the in-memory state container service seems pretty strait forward and needs very little setup to have it working. Fluxor comes with more functionality like a dispatcher, actions, features, effects. A complete solution to support the observer code pattern and CQRS. But does this all help to fix the Challenge!?

## Challenge

Implement a counter of TodoItems just like the one on the todopage but place it in the navigation menu on the todo link description. Depending on your solution there will be a problem with the update of the amount of items.