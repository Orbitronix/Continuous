using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Continuous
{
    public partial class ExampleForm : Form
    {
        private readonly GradeCollection m_gradeCollection = new GradeCollection();
        private readonly Student m_student = new Student() { Naam = "Vic" };

        public ExampleForm()
        {
            InitializeComponent();
            txtStudent.Text = m_student.Naam;
            m_gradeCollection.Changed += OnGradeCollectionChanged;
        }

        private void OnGradeCollectionChanged()
        {
            lbGrades.Items.Clear();
            foreach(var grade in m_gradeCollection.GetGradesForStudent(m_student))
            {
                string format = grade.Value.ToString("##.#");
                lbGrades.Items.Add(format);
            }
        }

        private void BtnAddGrade_Click(object sender, EventArgs e)
        {
            float value;
            try
            {
                if (float.TryParse(txtGrade.Text, out value))
                {
                    Grade grade = new Grade()
                    {
                        Student = m_student
                    };
                    grade.SetScore(value);
                    m_gradeCollection.AddGrade(grade);
                }
                else
                {
                    MessageBox.Show("Not a valid number");
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }

            txtGrade.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            m_gradeCollection.Clear();
        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            float average = AverageCalculator.CalculateMeanAverage(m_gradeCollection.GetGradesForStudent(m_student));
            txtAverage.Text = average.ToString("##.##");
        }
    }
}
