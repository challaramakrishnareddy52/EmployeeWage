﻿namespace EmployeeWage
{
    internal interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int empRateperHour, int numOfWorkingDays, int maxHoursPermonth);
        public void ComputeEmpWage();
    }
}
