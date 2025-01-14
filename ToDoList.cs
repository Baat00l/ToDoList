using System.Collections.Generic;

public class TodoList
{
    private List<string> tasks;

    public TodoList()
    {
        tasks = new List<string>();
    }

    public void AddTask(string task)
    {
        if (!string.IsNullOrWhiteSpace(task))
        {
            tasks.Add(task);
        }
    }

    public void RemoveTask(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
        }
    }

    public List<string> GetTasks()
    {
        return new List<string>(tasks);
    }
}
