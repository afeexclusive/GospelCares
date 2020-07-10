using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GospelCares.Models.ForIscholar
{
    public class EventReport
    {
        public Guid EventReportId { get; set; }
        public Guid SchoolId { get; set; }
        public string TeacherName { get; set; }
        public string SchoolSession { get; set; }
        public string Term { get; set; }
        public string Week { get; set; }
        public DateTime DateOfMeeting { get; set; }
        public DateTime TimeStarted { get; set; }
        public DateTime TimeEnded { get; set; }
        public int MaleStudents { get; set; }
        public int FemaleStudents { get; set; }
        public int NumberOfTeachers { get; set; }
        public int TotalAttendance { get; set; }
        public string ReportFilePath { get; set; }


    }
}
