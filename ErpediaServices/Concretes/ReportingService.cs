using ErpediaServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErpediaBusiness;

namespace ErpediaServices.Concretes
{
    public class ReportingService : IReportingService
    {
        public IQueryable<DDGeneralReports> GetGeneralReport()
        {
            throw new NotImplementedException();
        }
    }
}
