namespace studyPlanner
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("나눔고딕", 6.749999F);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 73);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "YEAR/MONTH/DAY";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("나눔고딕", 6.749999F);
            groupBox2.Location = new Point(324, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(144, 73);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "D-DAY";
            // 
            // groupBox3
            // 
            groupBox3.Font = new Font("나눔고딕", 6.749999F);
            groupBox3.Location = new Point(12, 91);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(306, 73);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "COMMENT";
            // 
            // groupBox4
            // 
            groupBox4.Font = new Font("나눔고딕", 6.749999F);
            groupBox4.Location = new Point(324, 91);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(144, 73);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "TOTAL TABLE";
            // 
            // groupBox5
            // 
            groupBox5.Font = new Font("나눔고딕", 6.749999F, FontStyle.Regular, GraphicsUnit.Point, 129);
            groupBox5.ForeColor = SystemColors.ControlText;
            groupBox5.Location = new Point(12, 170);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(306, 502);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "TASKS";
            // 
            // groupBox6
            // 
            groupBox6.Font = new Font("나눔고딕", 6.749999F);
            groupBox6.Location = new Point(324, 170);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(144, 502);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            groupBox6.Text = "TIMETABLE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 684);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
    }
}
