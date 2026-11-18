using StudentGrades.Models;
using StudentGrades.Repositories;
using StudentGrades.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace StudentGrades
{
    public partial class Form1 : Form
    {
        private SchoolContext _db = new SchoolContext();
        private CourseRepository _courseRepo = new CourseRepository();
        private int _selectedGradeId = 0;
        private int _selectedCourseId = 0;

        public Form1()
        {
            InitializeComponent();

            // Hadisələrin (Events) avtomatik bağlanması
            this.Load += Form1_Load;
            cmbStudents.SelectedIndexChanged += cmbStudents_SelectedIndexChanged;
            btnAddGrade.Click += btnAddGrade_Click;
            btnUpdateGrade.Click += btnUpdateGrade_Click;
            btnDeleteGrade.Click += btnDeleteGrade_Click;
            dgvGrades.CellClick += dgvGrades_CellClick;

            cmbSortCourses.SelectedIndexChanged += cmbSortCourses_SelectedIndexChanged;
            btnAddCourse.Click += btnAddCourse_Click;
            btnUpdateCourse.Click += btnUpdateCourse_Click;
            btnDeleteCourse.Click += btnDeleteCourse_Click;
            dgvCourses.CellClick += dgvCourses_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SeedInitialDataIfEmpty();
            LoadCombos();
            LoadGrades();
            LoadCourses();
        }

        private void SeedInitialDataIfEmpty()
        {
            if (!_db.Students.Any())
            {
                _db.Students.Add(new Student { FullName = "Əli Məmmədov" });
                _db.Students.Add(new Student { FullName = "Leyla Həsənova" });
                _db.SaveChanges();
            }
            if (!_db.Courses.Any())
            {
                _db.Courses.Add(new Course { Title = "C# Proqramlaşdırma", Credits = 6 });
                _db.Courses.Add(new Course { Title = "Verilənlər Bazası", Credits = 5 });
                _db.SaveChanges();
            }
        }

        private void LoadCombos()
        {
            cmbStudents.DataSource = _db.Students.ToList();
            cmbStudents.DisplayMember = "FullName";
            cmbStudents.ValueMember = "Id";

            cmbCourses.DataSource = _courseRepo.GetAll();
            cmbCourses.DisplayMember = "Title";
            cmbCourses.ValueMember = "Id";
        }

        private void LoadGrades()
        {
            var list = _db.Grades
                .Include(g => g.Student)
                .Include(g => g.Course)
                .Select(g => new
                {
                    g.Id,
                    Telebe = g.Student.FullName,
                    Fenn = g.Course.Title,
                    Qiymet = g.Score
                })
                .ToList();

            dgvGrades.DataSource = list;
            CalculateStudentAverage();
        }

        private void CalculateStudentAverage()
        {
            if (cmbStudents.SelectedValue == null || !(cmbStudents.SelectedValue is int)) return;
            int studentId = (int)cmbStudents.SelectedValue;

            var studentGrades = _db.Grades.Where(g => g.StudentId == studentId);

            if (studentGrades.Any())
            {
                double avg = studentGrades.Average(g => g.Score);
                lblAverage.Text = $"Orta bal: {avg:F2}";
            }
            else
            {
                lblAverage.Text = "Qiymət yoxdur";
            }
        }

        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateStudentAverage();
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("Qiymət 0 ilə 100 arasında olmalıdır!");
                return;
            }

            var grade = new Grade
            {
                StudentId = (int)cmbStudents.SelectedValue,
                CourseId = (int)cmbCourses.SelectedValue,
                Score = score
            };

            _db.Grades.Add(grade);
            _db.SaveChanges();
            LoadGrades();
        }

        private void dgvGrades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedGradeId = (int)dgvGrades.Rows[e.RowIndex].Cells["Id"].Value;
                txtScore.Text = dgvGrades.Rows[e.RowIndex].Cells["Qiymet"].Value.ToString();
            }
        }

        private void btnUpdateGrade_Click(object sender, EventArgs e)
        {
            if (_selectedGradeId == 0) return;
            if (!int.TryParse(txtScore.Text, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("Qiymət 0–100 aralığında olmalıdır!");
                return;
            }

            var grade = _db.Grades.Find(_selectedGradeId);
            if (grade != null)
            {
                grade.StudentId = (int)cmbStudents.SelectedValue;
                grade.CourseId = (int)cmbCourses.SelectedValue;
                grade.Score = score;
                _db.SaveChanges();
                LoadGrades();
            }
        }

        private void btnDeleteGrade_Click(object sender, EventArgs e)
        {
            if (_selectedGradeId == 0) return;
            var grade = _db.Grades.Find(_selectedGradeId);
            if (grade != null)
            {
                _db.Grades.Remove(grade);
                _db.SaveChanges();
                _selectedGradeId = 0;
                LoadGrades();
            }
        }

        private void LoadCourses()
        {
            var courses = _courseRepo.GetAll();

            if (cmbSortCourses.SelectedItem?.ToString() == "Kreditə görə")
            {
                courses = courses.OrderByDescending(c => c.Credits).ToList();
            }
            else if (cmbSortCourses.SelectedItem?.ToString() == "Ada görə")
            {
                courses = courses.OrderBy(c => c.Title).ToList();
            }

            dgvCourses.DataSource = courses.Select(c => new { c.Id, c.Title, c.Credits }).ToList();
            lblCourseCount.Text = $"Ümumi fənn sayı: {_courseRepo.Count()}";
            LoadCombos();
        }

        private void cmbSortCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseTitle.Text) || !int.TryParse(txtCredits.Text, out int credits))
                return;

            _courseRepo.Add(new Course { Title = txtCourseTitle.Text, Credits = credits });
            LoadCourses();
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedCourseId = (int)dgvCourses.Rows[e.RowIndex].Cells["Id"].Value;
                txtCourseTitle.Text = dgvCourses.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtCredits.Text = dgvCourses.Rows[e.RowIndex].Cells["Credits"].Value.ToString();
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            if (_selectedCourseId == 0 || !int.TryParse(txtCredits.Text, out int credits)) return;

            _courseRepo.Update(new Course
            {
                Id = _selectedCourseId,
                Title = txtCourseTitle.Text,
                Credits = credits
            });
            LoadCourses();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            if (_selectedCourseId == 0) return;

            try
            {
                _courseRepo.Delete(_selectedCourseId);
                _selectedCourseId = 0;
                LoadCourses();
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Bu fənnə aid tələbə qiymətləri mövcud olduğu üçün silinə bilməz!",
                                "Silmə xətası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Qiymetler_Click(object sender, EventArgs e)
        {

        }

        private void txtCourseTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}