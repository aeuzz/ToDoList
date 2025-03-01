namespace ToDoList
{
    partial class frmToDoList
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
            txtTask = new TextBox();
            lstTasks = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnComplete = new Button();
            lblTitle = new Label();
            lblTotalTasks = new Label();
            rbtnHigh = new RadioButton();
            rbtnMedium = new RadioButton();
            rbtnLow = new RadioButton();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            chkDarkMode = new CheckBox();
            colorDialog1 = new ColorDialog();
            btnCustomizeTheme = new Button();
            SuspendLayout();
            // 
            // txtTask
            // 
            txtTask.Location = new Point(20, 50);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(320, 27);
            txtTask.TabIndex = 0;
            // 
            // lstTasks
            // 
            lstTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 28;
            lstTasks.Location = new Point(20, 90);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(450, 200);
            lstTasks.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.ForestGreen;
            btnAdd.Location = new Point(350, 50);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Task";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.MediumTurquoise;
            btnEdit.Location = new Point(20, 300);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(128, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit Task";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.LightCoral;
            btnDelete.Location = new Point(154, 300);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(149, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Task";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplete.ForeColor = Color.Orange;
            btnComplete.Location = new Point(309, 300);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(161, 30);
            btnComplete.TabIndex = 5;
            btnComplete.Text = "Mark Completed";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(125, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(149, 38);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "To-Do List";
            // 
            // lblTotalTasks
            // 
            lblTotalTasks.AutoSize = true;
            lblTotalTasks.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalTasks.ForeColor = Color.DarkBlue;
            lblTotalTasks.Location = new Point(20, 340);
            lblTotalTasks.Name = "lblTotalTasks";
            lblTotalTasks.Size = new Size(126, 152);
            lblTotalTasks.TabIndex = 7;
            lblTotalTasks.Text = "Total\r\nTasks : 0\r\n\r\n\r\n";
            // 
            // rbtnHigh
            // 
            rbtnHigh.AutoSize = true;
            rbtnHigh.Location = new Point(350, 342);
            rbtnHigh.Name = "rbtnHigh";
            rbtnHigh.Size = new Size(113, 24);
            rbtnHigh.TabIndex = 8;
            rbtnHigh.TabStop = true;
            rbtnHigh.Text = "High Priority";
            rbtnHigh.UseVisualStyleBackColor = true;
            // 
            // rbtnMedium
            // 
            rbtnMedium.AutoSize = true;
            rbtnMedium.Location = new Point(350, 372);
            rbtnMedium.Name = "rbtnMedium";
            rbtnMedium.Size = new Size(136, 24);
            rbtnMedium.TabIndex = 9;
            rbtnMedium.TabStop = true;
            rbtnMedium.Text = "Medium Priority";
            rbtnMedium.UseVisualStyleBackColor = true;
            // 
            // rbtnLow
            // 
            rbtnLow.AutoSize = true;
            rbtnLow.Location = new Point(350, 402);
            rbtnLow.Name = "rbtnLow";
            rbtnLow.Size = new Size(108, 24);
            rbtnLow.TabIndex = 10;
            rbtnLow.TabStop = true;
            rbtnLow.Text = "Low Priority";
            rbtnLow.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkDarkMode
            // 
            chkDarkMode.AutoSize = true;
            chkDarkMode.Location = new Point(10, 425);
            chkDarkMode.Name = "chkDarkMode";
            chkDarkMode.Size = new Size(105, 24);
            chkDarkMode.TabIndex = 11;
            chkDarkMode.Text = "Dark Mode";
            chkDarkMode.UseVisualStyleBackColor = true;
            chkDarkMode.CheckedChanged += chkDarkMode_CheckedChanged;
            // 
            // btnCustomizeTheme
            // 
            btnCustomizeTheme.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomizeTheme.ForeColor = Color.MediumOrchid;
            btnCustomizeTheme.Location = new Point(350, 425);
            btnCustomizeTheme.Name = "btnCustomizeTheme";
            btnCustomizeTheme.Size = new Size(120, 25);
            btnCustomizeTheme.TabIndex = 12;
            btnCustomizeTheme.Text = "Customize Theme";
            btnCustomizeTheme.UseVisualStyleBackColor = true;
            btnCustomizeTheme.Click += btnCustomizeTheme_Click;
            // 
            // frmToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(482, 453);
            Controls.Add(btnCustomizeTheme);
            Controls.Add(chkDarkMode);
            Controls.Add(rbtnLow);
            Controls.Add(rbtnMedium);
            Controls.Add(rbtnHigh);
            Controls.Add(lblTotalTasks);
            Controls.Add(lblTitle);
            Controls.Add(btnComplete);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lstTasks);
            Controls.Add(txtTask);
            Name = "frmToDoList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To-Do List Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTask;
        private ListBox lstTasks;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnComplete;
        private Label lblTitle;
        private Label lblTotalTasks;
        private RadioButton rbtnHigh;
        private RadioButton rbtnMedium;
        private RadioButton rbtnLow;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private CheckBox chkDarkMode;
        private ColorDialog colorDialog1;
        private Button btnCustomizeTheme;
    }
}
