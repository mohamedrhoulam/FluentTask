using FluentTaskManager.Server.Repositories;

namespace FluentTaskManager.Server.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IQueryable<Task> GetAllTasks()
        {
            return _taskRepository.GetAllTasks();
        }

        public Task GetTaskById(int id)
        {
            return _taskRepository.GetTaskById(id);
        }

        public void AddTask(Task task)
        {
            _taskRepository.AddTask(task);
        }

        public void DeleteTask(int id)
        {
            _taskRepository.DeleteTask(id);
        }

        public void UpdateTask(int id, Task task)
        {
            _taskRepository.UpdateTask(id, task);
        }
    }
}