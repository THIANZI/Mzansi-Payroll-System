using System;
using System.Collections.Generic;
using System.Text;

namespace Mzansi_Tech_Contractors_Payroll
{
        public class PayrollCalculator
        {
            private const double HourlyRate = 950.0;

            public double CalculateGross(double hours)
            {
                return hours * HourlyRate;
            }

            public double CalculateUIF(double gross)
            {
                return gross * 0.01;
            }

            public double CalculateMembership(double gross)
            {
                return gross * 0.13;
            }

            public double CalculatePAYE(double gross, int dependents)
            {
                double deductionFactor = gross * 0.0575 * dependents;
                double taxableAmount = gross - deductionFactor;
                return taxableAmount * 0.25;
            }

            public double CalculateTotalDeductions(double uif, double paye, double membership)
            {
                return uif + paye + membership;
            }

            public double CalculateNet(double gross, double uif, double paye, double membership)
            {
                return gross - (uif + paye + membership);
            }
        }
    }
