using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculum.Domain.Entities
{
    public class MasterOneYear
    {
        public int ID { get; set; }
        public Semester Semester { get; }
        public Cycle Cycle { get; }
        public Subject Subject { get; }
        public Department Department { get; }
        public bool Exam { get; set; }
        public bool DiffOffset { get; set; }
        public bool RTR { get; set; }
        public bool RR { get; set; }
        public bool RK { get; set; }
        public bool KR { get; set; }
        public bool KP { get; set; }
        public int Lectures { get; set; }
        public int Lectures1 { get; set; }
        public int Lectures2 { get; set; }
        public int Laboratirny { get; set; }
        public int Lab1 { get; set; }
        public int Lab2 { get; set; }
        public int Practical { get; set; }
        public int Pract1 { get; set; }
        public int Pract2 { get; set; }
        public int Classroom { get; set; }
        public int Independet { get; set; }
        public float Credit { get; set; }
    }
}
