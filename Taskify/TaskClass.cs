using System.Windows.Forms;



namespace TaskClass
{
    public class TaskObj
    {

        //Attributes
        private string TaskTitle = "";
        private string TaskDescription = "";
        private string TaskDueDate = "";
        private TaskPriority _TaskPriority = TaskPriority.Low;       //Low, Medium, High
        private TaskStatus _TaskStatus = TaskStatus.NotStarted;         //Not Started, In Progress, Completed



        public enum TaskPriority
        {
            Low,
            Medium,
            High
        }

        public enum TaskStatus
        {
            NotStarted,
            InProgress,
            Completed
        }
        

        //Getters and Setters: Properties
        public string Tasktitle
        {
            get { return TaskTitle; }
            set { TaskTitle = value; }
        }

        public string Taskdescription
        {
            get { return TaskDescription; }
            set { TaskDescription = value; }
        }

        public string Taskduedate
        {
            get { return TaskDueDate; }
            set { TaskDueDate = value; }
        }

        public TaskPriority Taskpriority
        {
            get { return _TaskPriority; }
            set { _TaskPriority = value; }
        }

        public TaskStatus Taskstatus
        {
            get { return _TaskStatus; }
            set { _TaskStatus = value; }
        }

        //Constructor: Allows for the Task to be created without any arguments passed
        public TaskObj()
        {

        }


        //Constructor: ALlows for the Task to be created with all arguments passed
        public TaskObj(string tasktitle, string taskdescription, string taskduedate, TaskPriority _taskpriority, TaskStatus _taskstatus)
        {
            TaskTitle = tasktitle;
            TaskDescription = taskdescription;
            TaskDueDate = taskduedate;
            _TaskPriority = _taskpriority;
            _TaskStatus = _taskstatus;
        }


        //Method: Display Task Details
        public string DisplayTaskDetails()
        {
            return "Task Title: " + TaskTitle + "\nTask Description: " + TaskDescription + "\nTask Due Date: " + TaskDueDate + "\nTask Priority: " + _TaskPriority + "\nTask Status: " + _TaskStatus;
        }

       
    }
}