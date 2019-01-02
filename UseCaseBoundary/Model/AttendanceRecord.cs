﻿using System;

namespace UseCaseBoundary.Model
{
    public class AttendanceRecord
    {
        public Time WorkingHours;
        public DateTime Date;
        public Time TimeIn;
        public Time TimeOut;
        public Time LateBy;
        public Time OverTime;
    }
}