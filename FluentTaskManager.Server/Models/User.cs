using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FluentTaskManager.Server.Models
{
    public enum UserRole
    {
        Admin,
        User,
        Guest
    }
    public class User
    {
        public int Id { get; set; }

        [Required] [StringLength(100)] public string Name { get; set; }

        [Required] [StringLength(100)] public string Email { get; set; }

        [Required] public string PasswordHash { get; set; }

        [Required] [StringLength(50)] public string FirstName { get; set; }

        [Required] [StringLength(50)] public string LastName { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public ICollection<Task> Tasks { get; set; }

        [Required] [StringLength(50)] public string Username { get; set; }

        public UserRole Role { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime? LastLoginDate { get; set; }

    }
}