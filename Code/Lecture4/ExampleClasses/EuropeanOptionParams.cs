using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4.ExampleClasses
{
    public struct EuropeanOptionParams
    {
        public OptionPayoff Type; 
        public double T; // expiry time as a year fraction
        public double K; // strike

        public EuropeanOptionParams(OptionPayoff type, double t, double k)
        {            
            if (type != OptionPayoff.Call && type != OptionPayoff.Put)
            {
                throw new InvalidOperationException("Invalid type for European option");
            }
            Type = type;
            T = t;
            K = k;
        }

        public string GetTypeName()
        {
            return Type.ToString();            
        }
    }
}
