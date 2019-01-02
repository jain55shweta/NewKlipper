﻿using System;
using System.Collections.Generic;
using DataAccess;
using DataAccess.EntityModel;
using DomainModel;
using MongoDB.Driver;
using UseCaseBoundary;

namespace UseCaseBoundaryImplementation
{
    public class AccessEventRepository : IAccessEventsRepository
    {
        private readonly AttendanceDBContext _context = null;

        public AccessEventRepository()
        {
            _context = AttendanceDBContext.Instance;
        }

        public AccessEvents GetAccessEventsByEmployeeId(int id)
        {
            var filter = Builders<AccessEvent>.Filter.Eq("ID", id);
            var listOfEntityAccessEvent = _context.AccessEvents
                .Find(filter)
                .ToList();

            var listOfDomainModelAccessEvent = ConvertEntityAccessEventToDomainModelAccessEvent(listOfEntityAccessEvent);
            AccessEvents accessEvents = new AccessEvents(listOfDomainModelAccessEvent);
            return accessEvents;
        }

        public List<DomainModel.Model.AccessEvent> ConvertEntityAccessEventToDomainModelAccessEvent(List<AccessEvent> listOfEntityAccessEvent)
        {
            List<DomainModel.Model.AccessEvent> listOfDomainModelAccessEvent = new List<DomainModel.Model.AccessEvent>();
            foreach (var domainModelAccessEvent in listOfEntityAccessEvent)
            {
                DomainModel.Model.AccessEvent accessEvent = new DomainModel.Model.AccessEvent();

                accessEvent.AccessPointID = domainModelAccessEvent.AccessPointID;
                accessEvent.AccessPointName = domainModelAccessEvent.AccessPointName;
                accessEvent.EmployeeID = domainModelAccessEvent.EmployeeID;
                accessEvent.EventTime = domainModelAccessEvent.EventTime;
                listOfDomainModelAccessEvent.Add(accessEvent);
            }

            return listOfDomainModelAccessEvent;
        }
    }
}