using Task = FluentTaskManager.Server.Models.Task;

namespace FluentTaskManager.Server.Services
{
    public interface ITaskService
    {
        IQueryable<Task> GetAllTasks();
        Task GetTaskById(int id);
        void AddTask(Task task);
        void DeleteTask(int id);
        void UpdateTask(int id, Task task);
    }
}