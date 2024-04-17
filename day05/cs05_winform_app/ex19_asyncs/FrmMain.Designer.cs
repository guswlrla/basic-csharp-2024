namespace ex19_asyncs
{
    partial class FrmMain
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
            TxtTarget = new TextBox();
            TxtSource = new TextBox();
            PrgCopy = new ProgressBar();
            label2 = new Label();
            label1 = new Label();
            BtnAsyncCopy = new Button();
            BtnCancel = new Button();
            BtnSyncCopy = new Button();
            BtnSetTarget = new Button();
            BtnGetSource = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtTarget);
            groupBox1.Controls.Add(TxtSource);
            groupBox1.Controls.Add(PrgCopy);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnAsyncCopy);
            groupBox1.Controls.Add(BtnCancel);
            groupBox1.Controls.Add(BtnSyncCopy);
            groupBox1.Controls.Add(BtnSetTarget);
            groupBox1.Controls.Add(BtnGetSource);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "비동기 전송";
            // 
            // TxtTarget
            // 
            TxtTarget.Location = new Point(75, 76);
            TxtTarget.Name = "TxtTarget";
            TxtTarget.ReadOnly = true;
            TxtTarget.Size = new Size(273, 23);
            TxtTarget.TabIndex = 4;
            // 
            // TxtSource
            // 
            TxtSource.Enabled = false;
            TxtSource.Location = new Point(75, 35);
            TxtSource.Name = "TxtSource";
            TxtSource.Size = new Size(273, 23);
            TxtSource.TabIndex = 4;
            // 
            // PrgCopy
            // 
            PrgCopy.Location = new Point(31, 161);
            PrgCopy.Name = "PrgCopy";
            PrgCopy.Size = new Size(352, 23);
            PrgCopy.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 79);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "타켓:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "소스 :";
            // 
            // BtnAsyncCopy
            // 
            BtnAsyncCopy.Location = new Point(155, 110);
            BtnAsyncCopy.Name = "BtnAsyncCopy";
            BtnAsyncCopy.Size = new Size(102, 35);
            BtnAsyncCopy.TabIndex = 1;
            BtnAsyncCopy.Text = "비동기화 복사";
            BtnAsyncCopy.UseVisualStyleBackColor = true;
            BtnAsyncCopy.Click += BtnAsyncCopy_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(281, 110);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(102, 35);
            BtnCancel.TabIndex = 0;
            BtnCancel.Text = "취소";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSyncCopy
            // 
            BtnSyncCopy.Location = new Point(31, 110);
            BtnSyncCopy.Name = "BtnSyncCopy";
            BtnSyncCopy.Size = new Size(102, 35);
            BtnSyncCopy.TabIndex = 0;
            BtnSyncCopy.Text = "동기화 복사";
            BtnSyncCopy.UseVisualStyleBackColor = true;
            BtnSyncCopy.Click += BtnSyncCopy_Click;
            // 
            // BtnSetTarget
            // 
            BtnSetTarget.Location = new Point(354, 76);
            BtnSetTarget.Name = "BtnSetTarget";
            BtnSetTarget.Size = new Size(29, 23);
            BtnSetTarget.TabIndex = 1;
            BtnSetTarget.Text = "...";
            BtnSetTarget.UseVisualStyleBackColor = true;
            BtnSetTarget.Click += BtnSetTarget_Click;
            // 
            // BtnGetSource
            // 
            BtnGetSource.Location = new Point(354, 35);
            BtnGetSource.Name = "BtnGetSource";
            BtnGetSource.Size = new Size(29, 23);
            BtnGetSource.TabIndex = 0;
            BtnGetSource.Text = "...";
            BtnGetSource.UseVisualStyleBackColor = true;
            BtnGetSource.Click += BtnGetSource_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 221);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            Text = "비동기 파일복사";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TxtTarget;
        private TextBox TxtSource;
        private ProgressBar PrgCopy;
        private Label label2;
        private Label label1;
        private Button BtnSetTarget;
        private Button BtnGetSource;
        private Button BtnAsyncCopy;
        private Button BtnSyncCopy;
        private Button BtnCancel;
    }
}
