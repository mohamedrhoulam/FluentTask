namespace FluentTaskManager.Server.Repositories;

public interface ITaskRepository
{
    IEnumerable<Task> GetAllTasks();
    Task GetTaskById(int id);
    void AddTask(Task task);
    void DeleteTask(int id);
    void UpdateTask(int id, Task task);
}