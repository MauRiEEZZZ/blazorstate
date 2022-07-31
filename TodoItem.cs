public record TodoItem
{
    public Guid Id { get; } = Guid.NewGuid();
    public string? Title { get; set; }
    public bool IsDone { get; set; }
}