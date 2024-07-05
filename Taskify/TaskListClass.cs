using System.Windows.Forms;
using System.Collections.Generic;
using TaskClass;
using System.Text;



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
                MessageBox.Show($"{Task.Tasktitle} Removed");
            }
            else
            {
                MessageBox.Show("Task Not Found");
            }

        }

        public Array DisplayTaskList()
        {
            return Tasks.ToArray();


            
        }


    }
}