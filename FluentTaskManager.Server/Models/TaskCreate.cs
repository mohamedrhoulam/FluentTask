public class TaskCreateModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int AssignedUserId { get; set; }
    public DateTime DueDate { get; set; }
    public string Priority { get; set; }
    public string Status { get; set; }
    public int ProjectId { get; set; }
}