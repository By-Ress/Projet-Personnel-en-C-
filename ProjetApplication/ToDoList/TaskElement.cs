namespace ToDoList;

public class TaskElement
{
    private bool TaskEnd;
    private string name;
    private string description;

    public TaskElement(string name, string description)
    {
        this.name = name;
        this.description = description;
        this.TaskEnd = false;
    }


    public string ToText()
    {
        if (TaskEnd)
        {
            return " est finis. \n";
        }
        else
        {
            return name + ": " + description + "\n";
        }
    }

    public void TaskEnded()
    {
        TaskEnd = true;
    }
}