using Microsoft.AspNetCore.Mvc;
using FluentTaskManager.Server.Repositories;
using Task = FluentTaskManager.Server.Models.Task;

namespace FluentTaskManager.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    private readonly ITaskRepository _taskRepository;

    public TaskController(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    [HttpGet]
    public IQueryable<Models.Task> GetAllTasks()
    {
        return _taskRepository.GetAllTasks();
    }

    [HttpGet("{id}")]
    public Models.Task? GetTaskById(int id)
    {
        return _taskRepository.GetTaskById(id);
    }

    [HttpPost]
    public void AddTask(Models.Task task)
    {
        _taskRepository.AddTask(task);
    }

    [HttpDelete("{id}")]
    public void DeleteTask(int id)
    {
        _taskRepository.DeleteTask(id);
    }

    [HttpPut("{id}")]
    public void UpdateTask(int id, Task task)
    {
        _taskRepository.UpdateTask(id, task);
    }
}