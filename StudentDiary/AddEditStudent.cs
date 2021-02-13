using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentDiary
{


    public partial class AddEditStudent : Form
    {
        private int _studentId;
        private Student _student;


        private FileHelper<List<Student>> _fileHelper = new FileHelper<List<Student>>(Program.FilePath);

        public AddEditStudent(int id = 0)
        {
            InitializeComponent();

            _studentId = id;

            GetStudentData();

            tbFirstName.Select();

            
        }


        private void GetStudentData()
        {
            if (_studentId != 0) // sprawdzenie czy kliknięcie w formę jest edycją czy dodaniem
            {

                Text = "Edytowanie danych ucznia";

                var students = _fileHelper.DeserializeFromFile(); // pobieranie danych z pliku xml do zmiennej students
                _student = students.FirstOrDefault(x => x.Id == _studentId); // pobranie do zmiennej student dane z pliku students w zależności od przekazanego ID

                AssignTextBoxes();


                if (_student == null)
                {
                    throw new Exception("Brak ucznia o podanym ID");
                }


            }
        }

        private void AssignTextBoxes()
        {
            
            tbId.Text = _student.Id.ToString();
            tbFirstName.Text = _student.FirstName;
            tbLastName.Text = _student.LastName;
            tbMathematic.Text = _student.Math;
            tbPhysic.Text = _student.Physics;
            tbTechnology.Text = _student.Technology;
            tbPolishLang.Text = _student.PolishLang;
            tbForeignLang.Text = _student.ForeignLang;
            rtbComments.Text = _student.Comments;
            cbAdditionalClasses.Checked = _student.AdditionalClasses;
        }



        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var students = _fileHelper.DeserializeFromFile();


            if (_studentId != 0)
            {
                students.RemoveAll(x => x.Id == _studentId);
            }
            else // jesli(if) id istnieje tzn ze dane sa edytowane jesli nie  istnieja (else) tzn, że jest to nowe wprowadzenie danych 
            {
                AssignIdToNewStudent(students);
            }

            AddStudentToList(students);

     
        }

        private void AssignIdToNewStudent(List<Student> students)
        {
            var studentWithHighestId = students.OrderByDescending(currentIdNumber => currentIdNumber.Id).FirstOrDefault();
            
            _studentId = studentWithHighestId == null ? 1 : studentWithHighestId.Id + 1;  // if else  warunek > if true 1 > else id+1
        }

        private void AddStudentToList(List<Student> students)
        {

            bool additionalClasses = IsAdditionalClassesChecked();

            Student student = new Student()
            {

                Id = _studentId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Comments = rtbComments.Text,
                Math = tbMathematic.Text,
                Physics = tbPhysic.Text,
                Technology = tbTechnology.Text,
                PolishLang = tbPolishLang.Text,
                ForeignLang = tbForeignLang.Text,
                AdditionalClasses = additionalClasses,
                

            };

            students.Add(student);

            _fileHelper.SerializeToFile(students);
            Close();
        }

        private bool IsAdditionalClassesChecked()
        {
            if (cbAdditionalClasses.Checked == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
