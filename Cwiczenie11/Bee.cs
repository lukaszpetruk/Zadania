using System;
using System.Collections.Generic;
using System.Text;

namespace Cwiczenie11
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25;
        public double WeightMg { get; private set; }
        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }
        virtual public double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
