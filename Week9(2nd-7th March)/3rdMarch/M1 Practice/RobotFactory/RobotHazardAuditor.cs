using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotFactory
{
    public class RobotSafetyException : Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
        }
    }
    internal class RobotHazardAuditor
    {
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            // Validate Arm Precision
            if (armPrecision < 0.0 || armPrecision > 1.0)
            {
                throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
            }

            // Validate Worker Density
            if (workerDensity < 1 || workerDensity > 20)
            {
                throw new RobotSafetyException("Error: Worker density must be 1-20");
            }

            double machineRiskFactor;

            // Validate Machinery State (Case-Sensitive)
            if (machineryState == "Worn")
            {
                machineRiskFactor = 1.3;
            }
            else if (machineryState == "Faulty")
            {
                machineRiskFactor = 2.0;
            }
            else if (machineryState == "Critical")
            {
                machineRiskFactor = 3.0;
            }
            else
            {
                throw new RobotSafetyException("Error: Unsupported machinery state");
            }

            // Calculate Hazard Risk
            double hazardRisk = ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);

            return hazardRisk;
        }
    }
}
