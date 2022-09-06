using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamAccessArrangements.Models;
//using ExamAccessArrangements.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
//using ExamAccessArrangements.ViewModels;
using System.Linq;
using GroupProfileSummary.Data;

namespace ExamAccessArrangements.Controllers
{
    public class ExamAccessArrangementsController : Controller
    {
        private readonly ProSolutionContext _pscontext;
        private readonly string sqlStudentInfo = "eea.spEAAStudentInfo_20220905LS";
        private readonly string sqlEnrolmentInfo = "eea.spEAAEnrolmentInfo_20220905LS";
        private readonly string sqlTimetableInfo = "eea.spEAATimetableAndRegisterInfo_20220905LS";
        private readonly string sqlpsALSInfo = "eea.spEAApsALSInfo_20220905LS";
        private readonly ProMonitorContext _pmcontext;
        private readonly string sqlpmALSInfo = "eea.spEAApmALSInfo_20220905LS";
        public ExamAccessArrangementsController(ProSolutionContext pscontext, string sqlStudentInfo, string sqlEnrolmentInfo, string sqlTimetableInfo, string sqlALSInfo,ProMonitorContext pmcontext, string sqlpmALSInfo)
        {
            _pscontext = pscontext;
            this.sqlStudentInfo = sqlStudentInfo;
            this.sqlEnrolmentInfo = sqlEnrolmentInfo;
            this.sqlTimetableInfo = sqlTimetableInfo;
            this.sqlpsALSInfo = sqlALSInfo;
            _pmcontext = pmcontext;
            this.sqlpmALSInfo = sqlpmALSInfo;
        }
    }
}