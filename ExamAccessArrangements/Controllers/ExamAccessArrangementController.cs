using ExamAccessArrangements.Data;
using ExamAccessArrangements.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ExamAccessArrangements.ViewModels;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using Microsoft.Identity.Client;
using System.Collections.Immutable;

namespace ExamAccessArrangements.Controllers
{
    public class ExamAccessArrangementsController : Controller
    {
        private readonly ProSolutionContext _pscontext;
        private readonly string sqlStudentInfo = "eaa.spEAAStudentInfo_20220905LS @AY, @RefNo, @SD";
        private readonly string sqlEnrolmentInfo = "eaa.spEAAEnrolmentInfo_20220905LS @AY, @RefNo, @SD";
        private readonly string sqlTimetableInfo = "eaa.spEAATimetableAndRegisterInfo_20220905LS";
        private readonly string sqlpsALSInfo = "eaa.spEAApsALSInfo_20220905LS @AY, @RefNo";
        private readonly string sqlpsReferralList = "eaa.spEAAReferralList_20221005LS @AY";
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

            StudentInfo si = new StudentInfo
            {
                Student = student.FirstOrDefault()
            };
            return View(si);
        }

        public IActionResult ReferralList(string? AY)
        {
            ViewBag.AY = AY;
            SqlParameter p1 = new("@AY", AY);

            var ReferralList = _pscontext.Referrals.FromSqlRaw(sqlpsReferralList, p1).ToList();

             Referral rl = new Referral
            {
                Referrals = ReferralList.ToList()
            };
            return View(rl);
        }
    }
}
