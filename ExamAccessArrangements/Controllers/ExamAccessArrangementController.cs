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
        public ExamAccessArrangementsController(ProSolutionContext pscontext, string sqlStudentInfo, string sqlEnrolmentInfo, string sqlTimetableInfo, string sqlALSInfo, ProMonitorContext pmcontext, string sqlpmALSInfo)
        {
            _pscontext = pscontext;
            this.sqlStudentInfo = sqlStudentInfo;
            this.sqlEnrolmentInfo = sqlEnrolmentInfo;
            this.sqlTimetableInfo = sqlTimetableInfo;
            this.sqlpsALSInfo = sqlALSInfo;
            _pmcontext = pmcontext;
            this.sqlpmALSInfo = sqlpmALSInfo;
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