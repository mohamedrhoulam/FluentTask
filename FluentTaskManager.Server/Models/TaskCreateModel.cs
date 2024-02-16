using FluentTaskManager.Server.Models;
using TaskStatus = FluentTaskManager.Server.Models.TaskStatus;

public class TaskCreateModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int AssignedUserId { get; set; }
    public DateTime DueDate { get; set; }
    public TaskPriority Priority { get; set; }
    public TaskStatus Status { get; set; }
}