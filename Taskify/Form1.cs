using TaskClass;
using TaskListClass;


namespace Taskify
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TaskObj Test = new TaskObj();
            TaskObj Test2 = new TaskObj("Hello World", "Hi", "tmr", TaskObj.TaskPriority.Low, TaskObj.TaskStatus.NotStarted);
            TaskList list = new TaskList();
            list.AddTask(Test);
            list.AddTask(Test2);
            list.DisplayTaskList();
            list.RemoveTask(Test2);
        }
    }
}
