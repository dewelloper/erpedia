using ErpediaBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpediaServices.Interfaces
{
    public interface IReportingService
    {
        IQueryable<DDGeneralReports> GetGeneralReport();
    }
}
