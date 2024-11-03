namespace ToDo.Application.DTOs
{
    public record ToDoDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public Guid UserId { get; set; }
    }
}
