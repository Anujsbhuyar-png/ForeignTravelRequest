using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.BL.ViewModels;

namespace FTR.BL
{
    public interface IDashboardService
    {
        Task<List<DashboardViewModel>> GetDashboardViewModelsAsync();
    }
}
