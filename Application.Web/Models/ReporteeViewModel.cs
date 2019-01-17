﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UseCaseBoundary.Model;

namespace Application.Web.Models
{
    public class ReporteeViewModel : LayoutViewModel
    {
        public List<string> reportees = new List<string>();

        public List<AttendanceRecordDTO> reporteesAttendaceRecords = new List<AttendanceRecordDTO>();

        public string Name;

        public DateTime fromDate;

        public DateTime toDate;

    }
}
