//Список задач (ToDo-list):
/*написать приложение для ввода списка задач;
задачу описать классом ToDo с полями Title и IsDone;
на старте, если есть файл tasks.json/xml/bin (выбрать формат), загрузить из него массив имеющихся задач и вывести их на экран;
если задача выполнена, вывести перед её названием строку «[x]»;
вывести порядковый номер для каждой задачи;
при вводе пользователем порядкового номера задачи отметить задачу с этим порядковым номером как выполненную;
записать актуальный массив задач в файл tasks.json/xml/bin.*/

using Newtonsoft.Json;

bool continueJob = true;
var fileName = "ToDo.json";

while (continueJob)
{
    Console.WriteLine("Please choose an option: ");
    DisplayMenu();

    string userCodeChoice = Console.ReadLine();
    int intUserCodeChoice = int.Parse(userCodeChoice);

    switch (intUserCodeChoice)
    {
        case 1:
            EnterTask();
            break;
        case 2:
            CloseTask();
            break;
        case 3: continueJob = false;
            break;
        default: Console.WriteLine("Wrong choice! Choose between 1 and 3");
            break;
    }
}

void EnterTask()
{
    Console.WriteLine("Enter task name:");
    string taskName = Console.ReadLine();
    var newTask = new ToDo(taskName);
    var json = JsonConvert.SerializeObject(newTask);
    File.AppendAllText(fileName, json);
    File.AppendAllText(fileName, ",");
}

void CloseTask()
{
    Console.WriteLine("Enter task id you want to close");
    string json = File.ReadAllText(fileName);
    ToDo obj = JsonConvert.DeserializeObject<ToDo>(json); // падает ошибка в этом месте
    Console.Write(obj);
}

void DisplayMenu()
{
    Console.WriteLine("Enter 1 to add task");
    Console.WriteLine("Enter 2 to close task");
    Console.WriteLine("Enter 3 to exit");
}
public class ToDo
{
    private string _title;
    private bool _isDone;
    private int _index;
    public static int id = default;

    public ToDo()
    {

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