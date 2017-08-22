using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GradeCollection
    {
        public event Action Changed;

        private List<Grade> m_grades = new List<Grade>();

        public int Count => m_grades.Count;
        public void AddGrade(Grade grade)
        {
            if(grade == null)
            {
                throw new ArgumentNullException(nameof(grade));
            }

            if(m_grades.Contains(grade))
            {
                throw new ArgumentException($"Already contains grade {grade}", nameof(grade));
            }

            m_grades.Add(grade);
            Changed?.Invoke();
        }

        public void Clear()
        {
            m_grades.Clear();
            Changed?.Invoke();
        }

        public IEnumerable<Grade> GetGradesForStudent(Student student)
        {
            return m_grades.Where(x => x.Student == student);
        }
    }
}
