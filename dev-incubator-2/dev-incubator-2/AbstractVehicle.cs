﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev_incubator_2
{
    public abstract class AbstractVehicle : IComparable<AbstractVehicle>
    {
        public VehicleCosts vehicleCosts { get; set; }
        public double averageKilometers { get; set; }         

        public AbstractVehicle() { }

        public AbstractVehicle(VehicleCosts vehicleCosts, double averageKilometers) 
        {
            this.vehicleCosts = vehicleCosts;
            this.averageKilometers = averageKilometers;
        }

        public abstract double GetTotalCosts();
        //{ return averageCostKilometer * averageKilometers; }

        public override string ToString() => $"{vehicleCosts.name};{vehicleCosts.averageCostKilometer};{averageKilometers}"
                                .Replace(',', '.').Replace(';', ','); //Fix replacing ',' in numbers with '.'

        public int CompareTo(AbstractVehicle second) 
        {
            if (GetTotalCosts() < second.GetTotalCosts()) return -1;
            else if (GetTotalCosts() > second.GetTotalCosts()) return 1;
            else return 0;
        }

        //public override bool Equals(object obj)
        //{
        //    try 
        //    {
        //        AbstractVehicle second = (AbstractVehicle)obj;
        //        if (second != null && vehicleCosts.name.Equals(second.vehicleCosts.name)
        //            && vehicleCosts.averageCostKilometer.Equals(second.vehicleCosts.averageCostKilometer))
        //        {
        //            return true;
        //        }
        //        else return false;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
    }
}