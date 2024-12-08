namespace ToDoList;

public class Tache
{
    private string TaskName;
    private string Description;
    private List<TaskElement> Tasks = [];
    private int NumberOfTasks => Tasks.Count;

    public Tache(string taskName, string description)
    {
        this.TaskName = taskName;
        this.Description = description;
    }

    public Tache(string taskName)
    {
        this.TaskName = taskName;
        this.Description = "No description";
    }

    public void addTache(string name, string description)
    {
        TaskElement newTache = new TaskElement(name, description);
        this.Tasks.Add(newTache);
    }

    public void FinirTache(int index)
    {
        if (index > Tasks.Count || index < 0)
        {
            Console.WriteLine("Mauvais numero de taches, vous avez actuellement : " + NumberOfTasks + " taches.");
        }
        else
        {
            this.Tasks[index].TaskEnded();
        }
    }

    public string ToText()
    {
        string text = "" + this.TaskName + "\n" + this.Description + "\n";
        if (NumberOfTasks <= 0)
        {
            return text + "No tasks have been added.";
        }
        else
        {
            for (int i = 0; i < NumberOfTasks; i++)
            {
                text = text + "tache " + i + " ---> " + Tasks[i].ToText();
            }
        }
        return text;
    }

    public List<TaskElement> getTasks()
    {
        return Tasks;
    }
}