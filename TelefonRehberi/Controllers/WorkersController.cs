using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelefonRehberi.Data;
using TelefonRehberi.Models;

namespace TelefonRehberi.Controllers
{
    [Authorize]
    public class WorkersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public WorkersController(ApplicationDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var workersContext = _context.Worker.Include(w => w.Department);
            return View(await workersContext.ToListAsync());
        }

        public async Task<IActionResult> Error()
        {
            var workersContext = _context.Worker.Include(w => w.Department);
            return View(await workersContext.ToListAsync());
        }


        public async Task<IActionResult> ForAdmin()
        {
            var workersContext = _context.Worker.Include(w => w.Department);
            return View(await workersContext.ToListAsync());
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var worker = await _context.Worker.Include(w => w.Department).Include(a => a.WorkerManager).FirstOrDefaultAsync(m => m.WorkerId == id);
            if (worker == null)
            {
                return NotFound();
            }
            return View(worker);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<Department> departmentlist = new List<Department>();
            departmentlist = (from Department in _context.Department select Department).ToList();
            List<Worker> workerlist = new List<Worker>();
            workerlist = (from Worker in _context.Worker select Worker).ToList();
            Worker worker = new Worker();
            worker.departments = GetDepartments(departmentlist);
            worker.workers = GetWorkers(workerlist);
            return View(worker);
        }
        private IEnumerable<SelectListItem> GetDepartments(IEnumerable<Department> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.DepartmentId.ToString(),
                    Text = element.DepartmentName
                });
            }
            return selectList;
        }
        private IEnumerable<SelectListItem> GetWorkers(IEnumerable<Worker> elements)
        {
            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.WorkerId.ToString(),
                    Text = element.WorkerFirstName + " " + element.WorkerLastName
                });
            }
            return selectList;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Worker workermodel)
        {
            if (ModelState.IsValid)
            {
                Worker worker = new Worker();
                worker.WorkerFirstName = workermodel.WorkerFirstName;
                worker.WorkerLastName = workermodel.WorkerLastName;
                worker.WorkerPhoneNumber = workermodel.WorkerPhoneNumber;
                worker.DepartmentId = workermodel.DepartmentId;
                worker.WorkerManagerId = workermodel.WorkerManagerId;
                _context.Worker.Add(worker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            List<Department> departmentlist = new List<Department>();
            departmentlist = (from Department in _context.Department select Department).ToList();
            workermodel.departments = GetDepartments(departmentlist);
            List<Worker> workerlist = new List<Worker>();
            workerlist = (from Worker in _context.Worker select Worker).ToList();
            workermodel.workers = GetWorkers(workerlist);
            return View(workermodel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var worker = await _context.Worker.FindAsync(id);
            List<Department> departmentlist = new List<Department>();           
            departmentlist = _context.Department.ToList();
            worker.departments = GetDepartments(departmentlist);
            List<Worker> workerlist = new List<Worker>();
            workerlist = _context.Worker.ToList();
            worker.workers = GetWorkers(workerlist);
            if (worker == null)
            {
                return NotFound();
            }
            return View(worker);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WorkerId,WorkerFirstName,WorkerLastName,WorkerPhoneNumber,DepartmentId,WorkerManagerId")] Worker worker)
        {
            if (id != worker.WorkerId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var existingworker = await _context.Worker.Include(w => w.Department).Include(a => a.WorkerManager).FirstOrDefaultAsync(w => w.WorkerId == worker.WorkerId);
                    existingworker.WorkerFirstName = worker.WorkerFirstName;
                    existingworker.WorkerLastName = worker.WorkerLastName;
                    existingworker.WorkerPhoneNumber = worker.WorkerPhoneNumber;
                    existingworker.DepartmentId = worker.DepartmentId;
                    existingworker.WorkerManagerId = worker.WorkerManagerId;
                    _context.Worker.Update(existingworker);
                    await _context.SaveChangesAsync();
                }            
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkerExists(worker.WorkerId))
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
            List<Department> departmentlist = new List<Department>();
            departmentlist = (from Department in _context.Department select Department).ToList();
            worker.departments = GetDepartments(departmentlist);
            List<Worker> workerlist = new List<Worker>();
            workerlist = (from Worker in _context.Worker select Worker).ToList();
            worker.workers = GetWorkers(workerlist);
            return View(worker);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var worker = await _context.Worker.Include(p => p.Department).Include(m => m.WorkerManager).FirstOrDefaultAsync(m => m.WorkerId == id);
            if (worker == null)
            {
                return NotFound();
            }
            return View(worker);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id, string message = null)
        {
            var worker = await _context.Worker.FindAsync(id);
            bool ismanager = (await _context.Worker.AnyAsync(w => w.WorkerManagerId == worker.WorkerId));
            if (!ismanager)
            {
                _context.Worker.Remove(worker);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else 
            {
                return RedirectToAction(nameof(Error));
            }         
        }

        private bool WorkerExists(int id)
        {
            return _context.Worker.Any(e => e.WorkerId == id);
        }

    }
}