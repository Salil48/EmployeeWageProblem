﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class IComputeEmpWage
    {
        public interface InterfaceEmployeeWage
        {
            public void addCompanies(string Company, int wagePerHour, int maxdays, int maxhours);

            public void computeWage();
        }
    }
}
