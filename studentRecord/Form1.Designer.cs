
namespace studentRecord
{
    partial class studentGradeForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentGradesTabControl = new System.Windows.Forms.TabControl();
            this.gradesTab = new System.Windows.Forms.TabPage();
            this.btSaveRecord = new System.Windows.Forms.Button();
            this.lbFinalExam = new System.Windows.Forms.Label();
            this.lbMajorTest = new System.Windows.Forms.Label();
            this.lbProject = new System.Windows.Forms.Label();
            this.lbQuiz2 = new System.Windows.Forms.Label();
            this.tbFinalExam = new System.Windows.Forms.TextBox();
            this.tbMajorTest = new System.Windows.Forms.TextBox();
            this.tbProject = new System.Windows.Forms.TextBox();
            this.tbQuiz2 = new System.Windows.Forms.TextBox();
            this.tbQuiz1 = new System.Windows.Forms.TextBox();
            this.lbQuiz1 = new System.Windows.Forms.Label();
            this.lbStudentId = new System.Windows.Forms.Label();
            this.idsComboBox = new System.Windows.Forms.ComboBox();
            this.recoredTab = new System.Windows.Forms.TabPage();
            this.lBoxStudentGradeReport = new System.Windows.Forms.ListBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.lbStudentGradesReport = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu.SuspendLayout();
            this.studentGradesTabControl.SuspendLayout();
            this.gradesTab.SuspendLayout();
            this.recoredTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // studentGradesTabControl
            // 
            this.studentGradesTabControl.Controls.Add(this.gradesTab);
            this.studentGradesTabControl.Controls.Add(this.recoredTab);
            this.studentGradesTabControl.Location = new System.Drawing.Point(0, 27);
            this.studentGradesTabControl.Name = "studentGradesTabControl";
            this.studentGradesTabControl.SelectedIndex = 0;
            this.studentGradesTabControl.Size = new System.Drawing.Size(800, 421);
            this.studentGradesTabControl.TabIndex = 1;
            // 
            // gradesTab
            // 
            this.gradesTab.Controls.Add(this.btSaveRecord);
            this.gradesTab.Controls.Add(this.lbFinalExam);
            this.gradesTab.Controls.Add(this.lbMajorTest);
            this.gradesTab.Controls.Add(this.lbProject);
            this.gradesTab.Controls.Add(this.lbQuiz2);
            this.gradesTab.Controls.Add(this.tbFinalExam);
            this.gradesTab.Controls.Add(this.tbMajorTest);
            this.gradesTab.Controls.Add(this.tbProject);
            this.gradesTab.Controls.Add(this.tbQuiz2);
            this.gradesTab.Controls.Add(this.tbQuiz1);
            this.gradesTab.Controls.Add(this.lbQuiz1);
            this.gradesTab.Controls.Add(this.lbStudentId);
            this.gradesTab.Controls.Add(this.idsComboBox);
            this.gradesTab.Location = new System.Drawing.Point(4, 22);
            this.gradesTab.Name = "gradesTab";
            this.gradesTab.Padding = new System.Windows.Forms.Padding(3);
            this.gradesTab.Size = new System.Drawing.Size(792, 395);
            this.gradesTab.TabIndex = 0;
            this.gradesTab.Text = "Student Record";
            this.gradesTab.UseVisualStyleBackColor = true;
            // 
            // btSaveRecord
            // 
            this.btSaveRecord.Location = new System.Drawing.Point(196, 291);
            this.btSaveRecord.Name = "btSaveRecord";
            this.btSaveRecord.Size = new System.Drawing.Size(307, 48);
            this.btSaveRecord.TabIndex = 13;
            this.btSaveRecord.Text = "Save Record";
            this.btSaveRecord.UseVisualStyleBackColor = true;
            this.btSaveRecord.Click += new System.EventHandler(this.btSaveRecord_Click);
            // 
            // lbFinalExam
            // 
            this.lbFinalExam.AutoSize = true;
            this.lbFinalExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFinalExam.Location = new System.Drawing.Point(100, 241);
            this.lbFinalExam.Name = "lbFinalExam";
            this.lbFinalExam.Size = new System.Drawing.Size(84, 16);
            this.lbFinalExam.TabIndex = 12;
            this.lbFinalExam.Text = "Final Exam";
            // 
            // lbMajorTest
            // 
            this.lbMajorTest.AutoSize = true;
            this.lbMajorTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajorTest.Location = new System.Drawing.Point(100, 204);
            this.lbMajorTest.Name = "lbMajorTest";
            this.lbMajorTest.Size = new System.Drawing.Size(82, 16);
            this.lbMajorTest.TabIndex = 11;
            this.lbMajorTest.Text = "Major Test";
            // 
            // lbProject
            // 
            this.lbProject.AutoSize = true;
            this.lbProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProject.Location = new System.Drawing.Point(100, 165);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(57, 16);
            this.lbProject.TabIndex = 10;
            this.lbProject.Text = "Project";
            // 
            // lbQuiz2
            // 
            this.lbQuiz2.AutoSize = true;
            this.lbQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuiz2.Location = new System.Drawing.Point(100, 130);
            this.lbQuiz2.Name = "lbQuiz2";
            this.lbQuiz2.Size = new System.Drawing.Size(50, 16);
            this.lbQuiz2.TabIndex = 9;
            this.lbQuiz2.Text = "Quiz 2";
            // 
            // tbFinalExam
            // 
            this.tbFinalExam.Location = new System.Drawing.Point(206, 237);
            this.tbFinalExam.Name = "tbFinalExam";
            this.tbFinalExam.Size = new System.Drawing.Size(121, 20);
            this.tbFinalExam.TabIndex = 8;
            // 
            // tbMajorTest
            // 
            this.tbMajorTest.Location = new System.Drawing.Point(206, 200);
            this.tbMajorTest.Name = "tbMajorTest";
            this.tbMajorTest.Size = new System.Drawing.Size(121, 20);
            this.tbMajorTest.TabIndex = 6;
            // 
            // tbProject
            // 
            this.tbProject.Location = new System.Drawing.Point(206, 161);
            this.tbProject.Name = "tbProject";
            this.tbProject.Size = new System.Drawing.Size(121, 20);
            this.tbProject.TabIndex = 5;
            // 
            // tbQuiz2
            // 
            this.tbQuiz2.Location = new System.Drawing.Point(206, 126);
            this.tbQuiz2.Name = "tbQuiz2";
            this.tbQuiz2.Size = new System.Drawing.Size(121, 20);
            this.tbQuiz2.TabIndex = 4;
            // 
            // tbQuiz1
            // 
            this.tbQuiz1.Location = new System.Drawing.Point(206, 83);
            this.tbQuiz1.Name = "tbQuiz1";
            this.tbQuiz1.Size = new System.Drawing.Size(121, 20);
            this.tbQuiz1.TabIndex = 3;
            // 
            // lbQuiz1
            // 
            this.lbQuiz1.AutoSize = true;
            this.lbQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuiz1.Location = new System.Drawing.Point(100, 87);
            this.lbQuiz1.Name = "lbQuiz1";
            this.lbQuiz1.Size = new System.Drawing.Size(50, 16);
            this.lbQuiz1.TabIndex = 2;
            this.lbQuiz1.Text = "Quiz 1";
            // 
            // lbStudentId
            // 
            this.lbStudentId.AutoSize = true;
            this.lbStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentId.Location = new System.Drawing.Point(100, 51);
            this.lbStudentId.Name = "lbStudentId";
            this.lbStudentId.Size = new System.Drawing.Size(79, 16);
            this.lbStudentId.TabIndex = 1;
            this.lbStudentId.Text = "Student ID";
            // 
            // idsComboBox
            // 
            this.idsComboBox.FormattingEnabled = true;
            this.idsComboBox.Location = new System.Drawing.Point(206, 51);
            this.idsComboBox.Name = "idsComboBox";
            this.idsComboBox.Size = new System.Drawing.Size(121, 21);
            this.idsComboBox.TabIndex = 0;
            // 
            // recoredTab
            // 
            this.recoredTab.Controls.Add(this.lBoxStudentGradeReport);
            this.recoredTab.Controls.Add(this.btGenerate);
            this.recoredTab.Controls.Add(this.lbStudentGradesReport);
            this.recoredTab.Location = new System.Drawing.Point(4, 22);
            this.recoredTab.Name = "recoredTab";
            this.recoredTab.Padding = new System.Windows.Forms.Padding(3);
            this.recoredTab.Size = new System.Drawing.Size(792, 395);
            this.recoredTab.TabIndex = 1;
            this.recoredTab.Text = "Record";
            this.recoredTab.UseVisualStyleBackColor = true;
            // 
            // lBoxStudentGradeReport
            // 
            this.lBoxStudentGradeReport.FormattingEnabled = true;
            this.lBoxStudentGradeReport.Location = new System.Drawing.Point(25, 73);
            this.lBoxStudentGradeReport.Name = "lBoxStudentGradeReport";
            this.lBoxStudentGradeReport.Size = new System.Drawing.Size(747, 303);
            this.lBoxStudentGradeReport.TabIndex = 2;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(561, 29);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(122, 28);
            this.btGenerate.TabIndex = 1;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // lbStudentGradesReport
            // 
            this.lbStudentGradesReport.AutoSize = true;
            this.lbStudentGradesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentGradesReport.Location = new System.Drawing.Point(24, 35);
            this.lbStudentGradesReport.Name = "lbStudentGradesReport";
            this.lbStudentGradesReport.Size = new System.Drawing.Size(166, 16);
            this.lbStudentGradesReport.TabIndex = 0;
            this.lbStudentGradesReport.Text = "Students Grade Report";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // studentGradeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentGradesTabControl);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "studentGradeForm1";
            this.Text = "Student Record";
            this.Load += new System.EventHandler(this.studentGradeForm1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.studentGradesTabControl.ResumeLayout(false);
            this.gradesTab.ResumeLayout(false);
            this.gradesTab.PerformLayout();
            this.recoredTab.ResumeLayout(false);
            this.recoredTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl studentGradesTabControl;
        private System.Windows.Forms.TabPage gradesTab;
        private System.Windows.Forms.Button btSaveRecord;
        private System.Windows.Forms.Label lbFinalExam;
        private System.Windows.Forms.Label lbMajorTest;
        private System.Windows.Forms.Label lbProject;
        private System.Windows.Forms.Label lbQuiz2;
        private System.Windows.Forms.TextBox tbFinalExam;
        private System.Windows.Forms.TextBox tbMajorTest;
        private System.Windows.Forms.TextBox tbProject;
        private System.Windows.Forms.TextBox tbQuiz2;
        private System.Windows.Forms.TextBox tbQuiz1;
        private System.Windows.Forms.Label lbQuiz1;
        private System.Windows.Forms.Label lbStudentId;
        private System.Windows.Forms.ComboBox idsComboBox;
        private System.Windows.Forms.TabPage recoredTab;
        private System.Windows.Forms.ListBox lBoxStudentGradeReport;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label lbStudentGradesReport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

