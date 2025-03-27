using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FTR.DL;
using FTR.BL.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FTR.BL
{
    public class DashboardService : IDashboardService
    {
        private readonly AppDbContext _context;

        public DashboardService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<DashboardViewModel>> GetDashboardViewModelsAsync()
        {
            return await _context.ForeignTravelRequest
                .Include(f => f.Employee)
                .Include(f => f.Status)
                .Select(f => new DashboardViewModel
                {
                    EmployeeName = f.Employee.EmployeeName,
                    Department = f.Employee.Department,
                    FtrId = f.FtrId,
                    VisaType = f.VisaType,
                    StatusId = f.StatusId,
                    StatusName = f.Status.statusName,
                    CurrentStep = f.CurrentStep
                })
                .ToListAsync();
        }
    }
}
