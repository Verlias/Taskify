using System;
using System.Windows.Forms;
using TaskClass;


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
            MessageBox.Show(Test.DisplayTaskDetails()); // Testing Display Task Detail Method Works
            MessageBox.Show(TaskObj.Add()); //Testing Static Method
        }
    }
}
