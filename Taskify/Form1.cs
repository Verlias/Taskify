using TaskClass;
using TaskListClass;


namespace Taskify
{
    public partial class Form1 : Form
    {

        private TaskList tasklist;


        public Form1()
        {

            tasklist = new TaskList(); //Instantiate TaskList
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Capture Inputs from TextBoxes and ComboBoxes
            string TaskTitle = textBox1.Text;
            string TaskDescription = textBox2.Text;
            string TaskDueDate = textBox3.Text;
       
            TaskClass.TaskObj.TaskPriority TaskPriority = (TaskClass.TaskObj.TaskPriority)comboBox1.SelectedIndex;

            if (comboBox1.SelectedIndex == -1)
            {
                TaskPriority = TaskClass.TaskObj.TaskPriority.Low;
            }

            TaskClass.TaskObj.TaskStatus TaskStatus = (TaskClass.TaskObj.TaskStatus)comboBox2.SelectedIndex;

            if (comboBox2.SelectedIndex == -1)
            {
                TaskStatus = TaskClass.TaskObj.TaskStatus.NotStarted;
            }


            //Instantiate TaskObj
            TaskObj Task = new TaskObj();
            Task.Tasktitle = TaskTitle;
            Task.Taskdescription = TaskDescription;
            Task.Taskduedate = TaskDueDate;
            Task.Taskpriority = TaskPriority;
            Task.Taskstatus = TaskStatus;

            //Add Task to TaskList
            tasklist.AddTask(Task);

            MessageBox.Show("Task Added");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tasklist.DisplayTaskList();
        }
    }
}
