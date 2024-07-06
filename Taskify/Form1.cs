using System.Diagnostics.Contracts;
using TaskClass;
using TaskListClass;


namespace Taskify
{
    public partial class Form1 : Form
    {

        private TaskList tasklist;
        int Timer;


        public Form1()
        {

            tasklist = new TaskList(); //Instantiate TaskList
            InitializeComponent();



            RefreshListBox1();


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

            RefreshListBox1();

        }

        private void RefreshListBox1()
        {
            listBox1.DataSource = null;
            listBox1.DisplayMember = "Tasktitle";


            listBox1.DataSource = tasklist.DisplayTaskList();
            listBox1.DisplayMember = "Tasktitle";

        }


        //Delete Task
        private void button2_Click(object sender, EventArgs e)
        {
            //Value may be Null
            var selectedTask = listBox1.SelectedItem as TaskObj;

            if (selectedTask != null)
            {

                tasklist.RemoveTask(selectedTask);
                RefreshListBox1();
            }
            else
            {
                MessageBox.Show("Please select a Task to delete.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int timerVal = Timer++;
            TimerBox.Text = timerVal.ToString();
        }

        private void StartTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void StopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
