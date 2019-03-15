﻿using System;

namespace DomainModel
{
    public class AccessEvent
    {
        public AccessEvent(
            int accessPointID,
            string accessPointName,
            int employeeID,
            DateTime eventTime)
        {
            AccessPointID = accessPointID;
            AccessPointName = accessPointName;
            EmployeeID = employeeID;
            EventTime = eventTime;
        }

        private readonly int AccessPointID;

        public bool FromMainDoor()
        {
            return AccessPointID == 16;
        }
        public bool FromRecreationDoor()
        {
            return AccessPointID == 19;
        }
        public bool FromGymnasiumDoor()
        {
            return AccessPointID == 18;
        }
        public bool FromServerRoom()
        {
            return AccessPointID == 17;
        }
        public bool FromUSBDeviceDoor()
        {
            return AccessPointID == 15;
        }
        private string AccessPointName { get; set; }

        public int EmployeeID { get; set; }

        public DateTime EventTime { get; set; }
    }
}