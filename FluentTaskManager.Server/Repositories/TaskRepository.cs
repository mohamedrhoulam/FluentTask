using FluentTaskManager.Server.Data;
using FluentTaskManager.Server.Models;
using System.Linq;
using Task = FluentTaskManager.Server.Models.Task;

namespace FluentTaskManager.Server.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _context;

        public TaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<Task> GetAllTasks()
        {
            return _context.Tasks;
        }

        public Task GetTaskById(int id)
        {
            return _context.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void AddTask(Task task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        public void DeleteTask(int id)
        {
            var task = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
            }
        }

        public void UpdateTask(int id, Task task)
        {
            var existingTask = _context.Tasks.FirstOrDefault(t => t.Id == id);
            if (existingTask != null)
            {
                existingTask = task;
                _context.SaveChanges();
            }
        }
    }
}