using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FTR.DL;

namespace FTR.UI.Controllers
{
    public class ForeignTravelRequestsController : Controller
    {
        private readonly AppDbContext _context;

        public ForeignTravelRequestsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ForeignTravelRequests
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.ForeignTravelRequest.Include(f => f.Employee).Include(f => f.Status);
            return View(await appDbContext.ToListAsync());
        }

        // GET: ForeignTravelRequests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foreignTravelRequest = await _context.ForeignTravelRequest
                .Include(f => f.Employee)
                .Include(f => f.Status)
                .FirstOrDefaultAsync(m => m.FtrId == id);
            if (foreignTravelRequest == null)
            {
                return NotFound();
            }
            return View(foreignTravelRequest);
        }

        // GET: ForeignTravelRequests/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.PersonalDetails, "employeeId", "DasId");
            ViewData["StatusId"] = new SelectList(_context.Status, "statusId", "statusDescription");
            return View();
        }

        // POST: ForeignTravelRequests/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FtrId,EmployeeId,VisaType,StatusId,CurrentStep")] ForeignTravelRequest foreignTravelRequest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(foreignTravelRequest);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.PersonalDetails, "employeeId", "DasId", foreignTravelRequest.EmployeeId);
            ViewData["StatusId"] = new SelectList(_context.Status, "statusId", "statusDescription", foreignTravelRequest.StatusId);
            return View(foreignTravelRequest);
        }

        // GET: ForeignTravelRequests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foreignTravelRequest = await _context.ForeignTravelRequest.FindAsync(id);
            if (foreignTravelRequest == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.PersonalDetails, "employeeId", "DasId", foreignTravelRequest.EmployeeId);
            ViewData["StatusId"] = new SelectList(_context.Status, "statusId", "statusDescription", foreignTravelRequest.StatusId);
            return View(foreignTravelRequest);
        }

        // POST: ForeignTravelRequests/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FtrId,EmployeeId,VisaType,StatusId,CurrentStep")] ForeignTravelRequest foreignTravelRequest)
        {
            if (id != foreignTravelRequest.FtrId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foreignTravelRequest);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ForeignTravelRequestExists(foreignTravelRequest.FtrId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.PersonalDetails, "employeeId", "DasId", foreignTravelRequest.EmployeeId);
            ViewData["StatusId"] = new SelectList(_context.Status, "statusId", "statusDescription", foreignTravelRequest.StatusId);
            return View(foreignTravelRequest);
        }

        // GET: ForeignTravelRequests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foreignTravelRequest = await _context.ForeignTravelRequest
                .Include(f => f.Employee)
                .Include(f => f.Status)
                .FirstOrDefaultAsync(m => m.FtrId == id);
            if (foreignTravelRequest == null)
            {
                return NotFound();
            }

            return View(foreignTravelRequest);
        }

        // POST: ForeignTravelRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foreignTravelRequest = await _context.ForeignTravelRequest.FindAsync(id);
            if (foreignTravelRequest != null)
            {
                _context.ForeignTravelRequest.Remove(foreignTravelRequest);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ForeignTravelRequestExists(int id)
        {
            return _context.ForeignTravelRequest.Any(e => e.FtrId == id);
        }
    }
}
