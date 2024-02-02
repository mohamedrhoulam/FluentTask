using System;
using System.ComponentModel.DataAnnotations;

namespace FluentTaskManager.Server.Models
{
    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed
    }

    public class Task
    {
        public int Id { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        [StringLength(500)] public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TimeSpan ExpectedDuration { get; set; }

        public TaskPriority Priority { get; set; }

        public TaskStatus Status { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime? CompletedDate { get; set; }

        public User AssignedUser { get; set; }

        public double CalculatePriorityScore()
        {
            double dueDateWeight = 0.3;
            double durationWeight = 0.2;
            double statusWeight = 0.2;
            double priorityWeight = 0.2;
            double userWorkloadWeight = 0.1;

            double dueDateScore = (DueDate - DateTime.Now).TotalDays <= 1 ? 1 : 0.1;
            double durationScore = ExpectedDuration.TotalHours <= 1 ? 1 : 0.1;
            double statusScore = Status == TaskStatus.NotStarted ? 1 : 0.1;
            double priorityScore = Priority == TaskPriority.High ? 1 : (Priority == TaskPriority.Medium ? 0.5 : 0.1);
            double userWorkloadScore = AssignedUser.Tasks.Count > 10 ? 0.1 : 1;

            priorityScore = dueDateWeight * dueDateScore + durationWeight * durationScore +
                                   statusWeight * statusScore + priorityWeight * priorityScore +
                                   userWorkloadWeight * userWorkloadScore;

            return priorityScore;
        }
    }
}

