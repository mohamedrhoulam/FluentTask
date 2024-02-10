using FluentTaskManager.Server.Models;
using System.Linq;
using Task = FluentTaskManager.Server.Models.Task;

namespace FluentTaskManager.Server.Repositories
{
    public interface ITaskRepository
    {
        IQueryable<Task> GetAllTasks();
        Task GetTaskById(int id);
        void AddTask(Task task);
        void DeleteTask(int id);
        void UpdateTask(int id, Task task);
    }
}