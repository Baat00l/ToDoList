using Xunit;

public class TodoListTests
{
    [Fact]
    public void AddTask_ShouldAddTask()
    {
        var todoList = new TodoList();
        todoList.AddTask("Test Task");
        Assert.Contains("Test Task", todoList.GetTasks());
    }

    [Fact]
    public void RemoveTask_ShouldRemoveTask()
    {
        var todoList = new TodoList();
        todoList.AddTask("Test Task");
        todoList.RemoveTask(0);
        Assert.DoesNotContain("Test Task", todoList.GetTasks());
    }

    [Fact]
    public void AddTask_ShouldNotAddEmptyTask()
    {
        var todoList = new TodoList();
        todoList.AddTask("");
        Assert.Empty(todoList.GetTasks());
    }

    [Fact]
    public void RemoveTask_ShouldNotThrowForInvalidIndex()
    {
        var todoList = new TodoList();
        var exception = Record.Exception(() => todoList.RemoveTask(-1));
        Assert.Null(exception);
    }
}
