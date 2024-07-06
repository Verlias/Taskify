namespace Taskify
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            StartTimer = new Button();
            StopTimer = new Button();
            TimerBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(446, 372);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Add Tasks";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(288, 379);
            listBox1.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(421, 227);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(421, 256);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(421, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Low", "Medium ", "High" });
            comboBox1.Location = new Point(421, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { " NotStarted", " InProgress", " Completed" });
            comboBox2.Location = new Point(421, 343);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(446, 401);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Delete Task";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(323, 231);
            label1.Name = "label1";
            label1.Size = new Size(66, 19);
            label1.TabIndex = 11;
            label1.Text = "Task Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(323, 260);
            label2.Name = "label2";
            label2.Size = new Size(81, 19);
            label2.TabIndex = 12;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(323, 289);
            label3.Name = "label3";
            label3.Size = new Size(70, 19);
            label3.TabIndex = 13;
            label3.Text = "Due Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(323, 318);
            label4.Name = "label4";
            label4.Size = new Size(56, 19);
            label4.TabIndex = 14;
            label4.Text = "Priority:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(323, 347);
            label5.Name = "label5";
            label5.Size = new Size(50, 19);
            label5.TabIndex = 15;
            label5.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(129, 9);
            label6.Name = "label6";
            label6.Size = new Size(67, 21);
            label6.TabIndex = 16;
            label6.Text = "Task List";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(680, 9);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 17;
            label7.Text = "Timer";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // StartTimer
            // 
            StartTimer.Location = new Point(632, 71);
            StartTimer.Name = "StartTimer";
            StartTimer.Size = new Size(75, 23);
            StartTimer.TabIndex = 19;
            StartTimer.Text = "Start";
            StartTimer.UseVisualStyleBackColor = true;
            StartTimer.Click += StartTimer_Click;
            // 
            // StopTimer
            // 
            StopTimer.Location = new Point(713, 71);
            StopTimer.Name = "StopTimer";
            StopTimer.Size = new Size(75, 23);
            StopTimer.TabIndex = 20;
            StopTimer.Text = "Stop";
            StopTimer.UseVisualStyleBackColor = true;
            StopTimer.Click += StopTimer_Click;
            // 
            // TimerBox
            // 
            TimerBox.Location = new Point(659, 42);
            TimerBox.Name = "TimerBox";
            TimerBox.Size = new Size(100, 23);
            TimerBox.TabIndex = 21;
            TimerBox.Text = "0";
            TimerBox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TimerBox);
            Controls.Add(StopTimer);
            Controls.Add(StartTimer);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Taskify";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
        private Label label8;
        private Button StartTimer;
        private Button StopTimer;
        private TextBox TimerBox;
    }
}
