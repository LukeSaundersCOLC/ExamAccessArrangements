using ExamAccessArrangements.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ExamAccessArrangements.Controllers
{
    public class ExamAccessArrangementsController : Controller
    {
        private readonly ProSolutionContext _pscontext;
        private readonly string sqlStudentInfo = "eea.spEAAStudentInfo_20220905LS @AY, @RefNo, @SD";
        private readonly string sqlEnrolmentInfo = "eea.spEAAEnrolmentInfo_20220905LS @AY, @RefNo, @SD";
        private readonly string sqlTimetableInfo = "eea.spEAATimetableAndRegisterInfo_20220905LS";
        private readonly string sqlpsALSInfo = "eea.spEAApsALSInfo_20220905LS @AY, @RefNo";
        private readonly ProMonitorContext _pmcontext;
        private readonly string sqlpmALSInfo = "eea.spEAApmALSInfo_20220905LS @AY, @RefNo";
        public ExamAccessArrangementsController(ProSolutionContext pscontext, ProMonitorContext pmcontext)
        {
            _pscontext = pscontext;
            _pmcontext = pmcontext;
        }
        public IActionResult Index(string? AY,string? RefNo)
        { ViewBag.AY = AY;
            SqlParameter p1 = new("@AY", AY);
            SqlParameter p2 = new("@RefNo", RefNo);

            var si = _pscontext.Student.FromSqlRaw(sqlStudentInfo, p1, p2).ToList();
            var ei = _pscontext.Enrolment.FromSqlRaw(sqlEnrolmentInfo, p1,p2).ToList();
            var ti = _pscontext.Timetables.FromSqlRaw(sqlTimetableInfo, p1, p2).ToList();
            var psals = _pscontext.PSALS.FromSqlRaw(sqlpsALSInfo, p1, p2).ToList();
            var pmals = _pmcontext.PMALS.FromSqlRaw(sqlpmALSInfo, p1, p2).ToList();
            
        }
        public IActionResult Index(string? AY, string? RefNo, string? SD)
        {
            ViewBag.AY = AY;
            SqlParameter p1 = new("@AY", AY);
            SqlParameter p2 = new("@RefNo", RefNo);
            SqlParameter p3 = new("@SD", SD);
           
            var s = _pscontext.Student.FromSqlRaw(sqlStudentInfo, p1, p2,p3).ToList();
            var e = _pscontext.Enrolment.FromSqlRaw(sqlEnrolmentInfo, p1, p2,p3).ToList();
            var t = _pscontext.Timetables.FromSqlRaw(sqlTimetableInfo, p1, p2).ToList();
            var psals = _pscontext.PSALS.FromSqlRaw(sqlpsALSInfo, p1, p2).ToList();
            var pmals = _pmcontext.PMALS.FromSqlRaw(sqlpmALSInfo, p1, p2).ToList();
            return View();
        }
    }
}