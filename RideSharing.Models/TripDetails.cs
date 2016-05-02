﻿using Microsoft.SqlServer.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideSharing.Models
{
    public class TripDetails
    {
        public long Id { get; set; }

        public long SimulationId { get; set; }

        public int CabId { get; set; }

        public long RideId { get; set; }

        public int PassengerCount { get; set; }

        public int SequenceNum { get; set; }

        public SqlGeography Destination { get; set; }

        public DateTime PickupDateTime { get; set; }

        public DateTime DropoffDateTime { get; set; }

        public DateTime ActualDropoffDateTime { get; set; }

        public int DelayTime { get; set; }

        public int WalkTime { get; set; }
    }
}
