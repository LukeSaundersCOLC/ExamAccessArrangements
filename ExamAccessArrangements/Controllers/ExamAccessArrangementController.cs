using ExamAccessArrangements.Data;
using ExamAccessArrangements.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using ExamAccessArrangements.ViewModels;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;

namespace ExamAccessArrangements.Controllers
{
    public class ExamAccessArrangementsController : Controller
    {
        private readonly ProSolutionContext _pscontext;
        private readonly string sqlStudentInfo = "eaa.spEAAStudentInfo_20220905LS @AY, @RefNo, @SD";
        private readonly string sqlEnrolmentInfo = "eaa.spEAAEnrolmentInfo_20220905LS @AY, @RefNo, @SD";
        private readonly string sqlTimetableInfo = "eaa.spEAATimetableAndRegisterInfo_20220905LS";
        private readonly string sqlpsALSInfo = "eaa.spEAApsALSInfo_20220905LS @AY, @RefNo";
        private readonly ProMonitorContext _pmcontext;
        private readonly string sqlpmALSInfo = "eaa.spEAApmALSInfo_20220905LS @AY, @RefNo";
        public ExamAccessArrangementsController(ProSolutionContext pscontext, ProMonitorContext pmcontext)
        {
            _pscontext = pscontext;
            _pmcontext = pmcontext;
        }
        public IActionResult Testing(string? AY, string? RefNo, string? SD)
        {
            ViewBag.AY = AY;
            SqlParameter p1 = new("@AY", AY);
            SqlParameter p2 = new("@RefNo", RefNo);
            SqlParameter p3 = new("@SD", SD);

            var student = _pscontext.Students.FromSqlRaw(sqlStudentInfo, p1, p2, p3).ToList();

            // var s = _pscontext.Student.FromSqlRaw(sqlStudentInfo, p1, p2, p3).FirstOrDefault();
            //var e = _pscontext.Enrolment.FromSqlRaw(sqlEnrolmentInfo, p1, p2, p3).ToList();
            //var t = _pscontext.Timetables.FromSqlRaw(sqlTimetableInfo, p1, p2).ToList();
            //var psals = _pscontext.PSALS.FromSqlRaw(sqlpsALSInfo, p1, p2).ToList();
            //var pmals = _pmcontext.PMALS.FromSqlRaw(sqlpmALSInfo, p1, p2).ToList();
            StudentInfo si = new StudentInfo
            {
                Student = student.FirstOrDefault()
            };
            return View(si);
        }
    }
}
