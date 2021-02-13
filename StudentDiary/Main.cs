using StudentDiary.Properties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDiary
{
    public partial class Main : Form
    {


        public bool IsMaximized
        {
            get
            {
                return Settings.Default.IsMaximize;
            }
            set
            {
                Settings.Default.IsMaximize = value;
            }
        }

        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);

        
        public Main()
        {
            InitializeComponent();

            RefreshDataGridView();

            SetColumnsHeader();

            if (IsMaximized) // brak wartosci automatycznie porównanie do true
            {
                WindowState = FormWindowState.Maximized;
            }

        }

        



        private void SetColumnsHeader() 
        {
            dgvDiary.Columns[0].HeaderText = "Numer";
            dgvDiary.Columns[1].HeaderText = "Imię";
            dgvDiary.Columns[2].HeaderText = "Nazwisko";
            dgvDiary.Columns[3].HeaderText = "Uwagi";
            dgvDiary.Columns[4].HeaderText = "Matematyka";
            dgvDiary.Columns[5].HeaderText = "Technologia";
            dgvDiary.Columns[6].HeaderText = "Fizyka";
            dgvDiary.Columns[7].HeaderText = "Język Polski";
            dgvDiary.Columns[8].HeaderText = "Język Obcy";
            dgvDiary.Columns[9].HeaderText = "Zajęcia dodatkowe";


           
        }


        public void RefreshDataGridView()
        {
            var allStudents = _fileHelper.DeserializeFromFile();
            dgvDiary.DataSource = allStudents;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditStudent = new AddEditStudent();

            addEditStudent.ShowDialog();

            RefreshDataGridView();

           
        }

        private  void btnEdit_Click(object sender, EventArgs e)
        {
         

            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz ucznia, którego dane chcesz edytować.");
                return; // return kończy funkcję bez wykonywania reszty kodu
            }

            var addEditStudent = new AddEditStudent(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value)); // pobiera

            addEditStudent.ShowDialog();

            RefreshDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dgvDiary.SelectedRows.Count == 0) // jeśli nie zaznaczono ucznia
            {
                MessageBox.Show("Proszę zaznacz ucznia, którego dane chcesz usunąć");
                return;
            }

            var selectedStudent = dgvDiary.SelectedRows[0];
            var selectedStudentFirstName = selectedStudent.Cells[1].Value.ToString();
            var selectedStudentLastName = selectedStudent.Cells[2].Value.ToString();

            var confirmDelete = MessageBox.Show(
                $"Czy napewno chcesz usunąć ucznia {(selectedStudentFirstName + " " + selectedStudentLastName).Trim()}", // wyświetlenie textu
                "Usuwanie ucznia", //Tytył
                MessageBoxButtons.OKCancel); // przyciski

            if (confirmDelete == DialogResult.OK)
            {

                int getStudentId = Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value);
                DeleteStudent(getStudentId);

            }


            RefreshDataGridView();

        }


        private void DeleteStudent(int id)
        {
            var deleteStudent = _fileHelper.DeserializeFromFile();

            int studentId = id; // pobiera wartość ID studenta
            deleteStudent.RemoveAll(x => x.Id == studentId);

            _fileHelper.SerializeToFile(deleteStudent);

        }



        private void dgwDiary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
            {
                IsMaximized = true;
            }
            else
            {
                IsMaximized = false;
            }

            Settings.Default.Save();

        }
    }
}