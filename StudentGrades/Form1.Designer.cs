namespace StudentGrades
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
            tabControl1 = new TabControl();
            Qiymetler = new TabPage();
            dgvGrades = new DataGridView();
            lblAverage = new Label();
            btnDeleteGrade = new Button();
            btnUpdateGrade = new Button();
            btnAddGrade = new Button();
            txtScore = new TextBox();
            cmbCourses = new ComboBox();
            cmbStudents = new ComboBox();
            tabPage2 = new TabPage();
            dgvCourses = new DataGridView();
            lblCourseCount = new Label();
            cmbSortCourses = new ComboBox();
            btnDeleteCourse = new Button();
            btnUpdateCourse = new Button();
            btnAddCourse = new Button();
            txtCredits = new TextBox();
            txtCourseTitle = new TextBox();
            tabControl1.SuspendLayout();
            Qiymetler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Qiymetler);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 29);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1122, 519);
            tabControl1.TabIndex = 0;
            // 
            // Qiymetler
            // 
            Qiymetler.Controls.Add(dgvGrades);
            Qiymetler.Controls.Add(lblAverage);
            Qiymetler.Controls.Add(btnDeleteGrade);
            Qiymetler.Controls.Add(btnUpdateGrade);
            Qiymetler.Controls.Add(btnAddGrade);
            Qiymetler.Controls.Add(txtScore);
            Qiymetler.Controls.Add(cmbCourses);
            Qiymetler.Controls.Add(cmbStudents);
            Qiymetler.Location = new Point(4, 29);
            Qiymetler.Name = "Qiymetler";
            Qiymetler.Padding = new Padding(3);
            Qiymetler.Size = new Size(1114, 486);
            Qiymetler.TabIndex = 0;
            Qiymetler.Text = "Qiymetler";
            Qiymetler.UseVisualStyleBackColor = true;
            Qiymetler.Click += Qiymetler_Click;
            // 
            // dgvGrades
            // 
            dgvGrades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGrades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGrades.Location = new Point(602, 3);
            dgvGrades.Name = "dgvGrades";
            dgvGrades.ReadOnly = true;
            dgvGrades.RowHeadersWidth = 51;
            dgvGrades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGrades.Size = new Size(509, 480);
            dgvGrades.TabIndex = 7;
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(19, 405);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(66, 20);
            lblAverage.TabIndex = 6;
            lblAverage.Text = "Orta bal:";
            // 
            // btnDeleteGrade
            // 
            btnDeleteGrade.Location = new Point(283, 341);
            btnDeleteGrade.Name = "btnDeleteGrade";
            btnDeleteGrade.Size = new Size(94, 29);
            btnDeleteGrade.TabIndex = 5;
            btnDeleteGrade.Text = "Sil";
            btnDeleteGrade.UseVisualStyleBackColor = true;
            // 
            // btnUpdateGrade
            // 
            btnUpdateGrade.Location = new Point(152, 341);
            btnUpdateGrade.Name = "btnUpdateGrade";
            btnUpdateGrade.Size = new Size(94, 29);
            btnUpdateGrade.TabIndex = 4;
            btnUpdateGrade.Text = "Yenile";
            btnUpdateGrade.UseVisualStyleBackColor = true;
            // 
            // btnAddGrade
            // 
            btnAddGrade.Location = new Point(19, 341);
            btnAddGrade.Name = "btnAddGrade";
            btnAddGrade.Size = new Size(94, 29);
            btnAddGrade.TabIndex = 3;
            btnAddGrade.Text = "Elave et";
            btnAddGrade.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(6, 248);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(151, 27);
            txtScore.TabIndex = 2;
            txtScore.Text = "Qiymet (0-100)";
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(6, 141);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(151, 28);
            cmbCourses.TabIndex = 1;
            cmbCourses.Text = "Fenn";
            // 
            // cmbStudents
            // 
            cmbStudents.FormattingEnabled = true;
            cmbStudents.Location = new Point(6, 51);
            cmbStudents.Name = "cmbStudents";
            cmbStudents.Size = new Size(151, 28);
            cmbStudents.TabIndex = 0;
            cmbStudents.Text = "Telebe";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvCourses);
            tabPage2.Controls.Add(lblCourseCount);
            tabPage2.Controls.Add(cmbSortCourses);
            tabPage2.Controls.Add(btnDeleteCourse);
            tabPage2.Controls.Add(btnUpdateCourse);
            tabPage2.Controls.Add(btnAddCourse);
            tabPage2.Controls.Add(txtCredits);
            tabPage2.Controls.Add(txtCourseTitle);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1114, 486);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Fenler";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(649, 0);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.ReadOnly = true;
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(465, 486);
            dgvCourses.TabIndex = 7;
            // 
            // lblCourseCount
            // 
            lblCourseCount.AutoSize = true;
            lblCourseCount.Location = new Point(18, 428);
            lblCourseCount.Name = "lblCourseCount";
            lblCourseCount.Size = new Size(134, 20);
            lblCourseCount.TabIndex = 6;
            lblCourseCount.Text = "Ümumi fənn sayı: 0";
            // 
            // cmbSortCourses
            // 
            cmbSortCourses.FormattingEnabled = true;
            cmbSortCourses.Items.AddRange(new object[] { "Ada görə", "Kreditə görə" });
            cmbSortCourses.Location = new Point(18, 372);
            cmbSortCourses.Name = "cmbSortCourses";
            cmbSortCourses.Size = new Size(151, 28);
            cmbSortCourses.TabIndex = 5;
            cmbSortCourses.Text = "Sirala";
            cmbSortCourses.SelectedIndexChanged += cmbSortCourses_SelectedIndexChanged;
            // 
            // btnDeleteCourse
            // 
            btnDeleteCourse.Location = new Point(274, 296);
            btnDeleteCourse.Name = "btnDeleteCourse";
            btnDeleteCourse.Size = new Size(94, 29);
            btnDeleteCourse.TabIndex = 4;
            btnDeleteCourse.Text = "Sil";
            btnDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCourse
            // 
            btnUpdateCourse.Location = new Point(147, 296);
            btnUpdateCourse.Name = "btnUpdateCourse";
            btnUpdateCourse.Size = new Size(94, 29);
            btnUpdateCourse.TabIndex = 3;
            btnUpdateCourse.Text = "Yenile";
            btnUpdateCourse.UseVisualStyleBackColor = true;
            // 
            // btnAddCourse
            // 
            btnAddCourse.Location = new Point(18, 296);
            btnAddCourse.Name = "btnAddCourse";
            btnAddCourse.Size = new Size(94, 29);
            btnAddCourse.TabIndex = 2;
            btnAddCourse.Text = "Elave et";
            btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(18, 153);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(125, 27);
            txtCredits.TabIndex = 1;
            txtCredits.Text = "Kredit sayı:";
            // 
            // txtCourseTitle
            // 
            txtCourseTitle.Location = new Point(18, 60);
            txtCourseTitle.Name = "txtCourseTitle";
            txtCourseTitle.Size = new Size(125, 27);
            txtCourseTitle.TabIndex = 0;
            txtCourseTitle.Text = "Fennin adı:";
            txtCourseTitle.TextChanged += txtCourseTitle_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1277, 584);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            tabControl1.ResumeLayout(false);
            Qiymetler.ResumeLayout(false);
            Qiymetler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGrades).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Qiymetler;
        private TabPage tabPage2;
        private TextBox txtScore;
        private ComboBox cmbCourses;
        private ComboBox cmbStudents;
        private DataGridView dgvGrades;
        private Label lblAverage;
        private Button btnDeleteGrade;
        private Button btnUpdateGrade;
        private Button btnAddGrade;
        private TextBox txtCredits;
        private TextBox txtCourseTitle;
        private ComboBox cmbSortCourses;
        private Button btnDeleteCourse;
        private Button btnUpdateCourse;
        private Button btnAddCourse;
        private Label lblCourseCount;
        private DataGridView dgvCourses;
    }
}
