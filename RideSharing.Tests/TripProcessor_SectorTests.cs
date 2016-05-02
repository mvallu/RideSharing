﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RideSharing.BL;
using RideSharing.DAL;
using RideSharing.Contract;
using System.Diagnostics;

namespace RideSharing.Tests
{
    [TestClass]
    public class TripProcessor_SectorTests
    {
        string URL = "http://192.168.0.111:5000/";
        RideDetailsRepository rideDetailsRepo;
        TripDetailsRepository tripDetailsRepo;
        IRideProcessor rideProcessor;
        ITripProcessor tripProcessor;

        [TestInitialize]
        public void Initialize()
        {
            rideDetailsRepo = new RideDetailsRepository();
            tripDetailsRepo = new TripDetailsRepository();
            rideProcessor = new RideProcessor(rideDetailsRepo);
            tripProcessor = new TripProcessor_Sector(tripDetailsRepo, rideProcessor, URL);
        }

        [TestMethod]
        public void TestProcessTripsForSmallPoolSize_Valid()
        {
            Trace.WriteLine("Small Pool Size");

            Assert.AreEqual(true, tripProcessor.ProcessTrips(20160402121216, "06/4/2013 15:30 PM", "06/4/2013 15:35 PM"));            
        }

        [TestMethod]
        public void TestProcessTripsForMediumPoolSize_Valid()
        {
            Trace.WriteLine("Medium Pool Size");

            Assert.AreEqual(true, tripProcessor.ProcessTrips(20160402121217, "02/16/2013 1:10 PM", "02/16/2013 1:25 PM"));
        }

        [TestMethod]
        public void TestProcessTripsForLargePoolSize_Valid()
        {
            Trace.WriteLine("Large Pool Size");

            Assert.AreEqual(true, tripProcessor.ProcessTrips(20160402121218, "06/4/2013 16:00 PM", "06/4/2013 16:20 PM"));
        }

        [TestMethod]
        public void TestProcessTripsForExtraLargePoolSize_Valid()
        {
            Trace.WriteLine("Extra Large Pool Size");

            Assert.AreEqual(true, tripProcessor.ProcessTrips(20160402121219, "02/4/2013 16:00 PM", "02/4/2013 16:30 PM"));
        }
    }
}
