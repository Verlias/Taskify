using System.Windows.Forms;
using System.Collections.Generic;
using TaskClass;



namespace TaskListClass
{
    public class TaskList
    {
        //List Attribute
        private List<TaskObj> Tasks;

        //List
        public TaskList()
        {
            Tasks = new List<TaskObj>();
        }


        //Add Task
        public void AddTask(TaskObj Task)
        {
            Tasks.Add(Task);
        }

        public void RemoveTask(TaskObj Task)
        {

            if (Tasks.Remove(Task))
            {
                Message.Box.Show("Task Removed");
            }
            else
            {
                Message.Box.Show("Task Not Found");
            }

        }

        public void DisplayTaskList()
        {
            foreach (TaskObj Task in Tasks)
            {
                MessageBox.Show(Task.DisplayTaskDetails());
            }
        }


    }
}