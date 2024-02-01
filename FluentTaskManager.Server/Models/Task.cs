using System;
using System.ComponentModel.DataAnnotations;

namespace FluentTaskManager.Server.Models
{
    public class Task
    {
        public int Id { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        [StringLength(500)] public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public TimeSpan ExpectedDuration { get; set; }
    }
}