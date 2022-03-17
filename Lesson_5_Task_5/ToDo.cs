//Список задач (ToDo-list):
/*написать приложение для ввода списка задач;
задачу описать классом ToDo с полями Title и IsDone;
на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
если задача выполнена, вывести перед её названием строку «[x]»;
вывести порядковый номер для каждой задачи;
при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
записать актуальный массив задач в файл tasks.json/xml/bin.*/

using System.Text.Json;

bool showMenu = true;
var saveFileName = "todo.json";

ToDo[] toDoArray = new ToDo[0];

while (showMenu)
{
    Console.WriteLine("Please choose an option: ");
    DisplayMenu();

    string userInput = Console.ReadLine();
    int intUserInputCode = int.Parse(userInput);

    switch (intUserInputCode)
    {
        case 1:
            EnterTask();
            break;
        case 2:
            CloseTask(DeserializeArray());
            break;
        case 3:
            DisplayResult();
            break;
        case 0: showMenu = false;
            break;
        default:
            Console.WriteLine("Wrong choice! Choose between 1 and 3");
            break;
    }
}

void DisplayResult()
{
    foreach(ToDo toDo in toDoArray)
    {
        if(toDo.IsDone == true)
        {
         Console.WriteLine($"[X] Index: {toDo.Index}\n[X] Title: {toDo.Title}\n[X] Done: {toDo.IsDone}");

        }
        else
        {
         Console.WriteLine($"Index: {toDo.Index}\nTitle: {toDo.Title}\nDone: {toDo.IsDone}");
        }
    }
}

void EnterTask()
{
    Console.WriteLine("Enter task name:");
    string taskName = Console.ReadLine();
    var taskObj = new ToDo(taskName);
    toDoArray = AddItemToArray(toDoArray, taskObj);
    SerializeArray(toDoArray);
}

ToDo[] DeserializeArray()
{
    var file = File.ReadAllText(saveFileName);
    var deserializedToDoArray = JsonSerializer.Deserialize<ToDo[]>(file);
    return deserializedToDoArray;
}

void SerializeArray(ToDo[] toDoArray)
{
    string json = JsonSerializer.Serialize(toDoArray);
    File.WriteAllText(saveFileName, json);
}

ToDo[] AddItemToArray(ToDo[] toDoArray, ToDo newTask)
{
    ToDo[] tempArray = new ToDo[toDoArray.Length+1];
    toDoArray.CopyTo(tempArray, 0);
    tempArray[toDoArray.Length] = newTask;
    return tempArray;
}

void CloseTask(ToDo[] desirializedArray)
{
    Console.WriteLine("Enter task id you want to close");
    int input = int.Parse(Console.ReadLine());
    foreach(ToDo toDo in desirializedArray)
    {
        if(toDo.Index == input)
        {
            foreach(ToDo todo in toDoArray)
            {
                if(todo.Index == input)
                {
                    todo.IsDone = true;
                }
            }
        }
    }
}
void DisplayMenu()
{
    Console.WriteLine("Enter 0 to exit");
    Console.WriteLine("Enter 1 to add task");
    Console.WriteLine("Enter 2 to close task");
    Console.WriteLine("Enter 3 to display result");
}

public class ToDo
{
    private string _title;
    private bool _isDone;
    private int _index;
    public static int id = default;

    public ToDo()
    {
        _title = "unknown";
        _isDone = false;
    }
    public ToDo(string title)
    {
        id++;
        Title = title;
        IsDone = false;
        Index = id;
    }

    public string Title { get; set; }
    public bool IsDone { get; set; }
    public int Index { get; set; }
}