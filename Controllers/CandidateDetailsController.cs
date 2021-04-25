using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Mywebproject_core.Data;
using Mywebproject_core.Models;

namespace Mywebproject_core.Controllers
{
    public class CandidateDetailsController : Controller
    {
        private readonly CandidateDetailContext _context;


        public CandidateDetailsController(CandidateDetailContext context)
        {
            _context = context;
        }
        CandidateDetail MyCandidateDetail1 = new CandidateDetail
        {
            name = "Harry",
            party = "Congress",
            candidate_status = "Active",
            state = "FL"
        };

        CandidateDetail MyCandidateDetail2 = new CandidateDetail
        {
            name = "Trump",
            party = "Republic",
            candidate_status = "Active",
            state = "NY"
        };

        CandidateDetail MyCandidateDetail3 = new CandidateDetail
        {
            name = "Biden",
            party = "Democratic",
            candidate_status = "Active",
            state = "PA"
        };

        CandidateDetail MyCandidateDetail4 = new CandidateDetail
        {
            name = "Barak",
            party = "Democratic",
            candidate_status = "Inactive",
            state = "HI"
        };


        // GET: CandidateDetails
        public async Task<IActionResult> Index()
        {
             

            return View(await _context.CandidateDetail.ToListAsync());
        }

        // GET: CandidateDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateDetail = await _context.CandidateDetail
                .FirstOrDefaultAsync(m => m.candidate_id == id);
            if (candidateDetail == null)
            {
                return NotFound();
            }

            return View(candidateDetail);
        }

        // GET: CandidateDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CandidateDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("candidate_id,name,party,candidate_status,state")] CandidateDetail candidateDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candidateDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candidateDetail);
        }

        // GET: CandidateDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateDetail = await _context.CandidateDetail.FindAsync(id);
            if (candidateDetail == null)
            {
                return NotFound();
            }
            return View(candidateDetail);
        }

        // POST: CandidateDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("candidate_id,name,party,candidate_status,state")] CandidateDetail candidateDetail)
        {
            if (id != candidateDetail.candidate_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candidateDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandidateDetailExists(candidateDetail.candidate_id))
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
            return View(candidateDetail);
        }

        // GET: CandidateDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candidateDetail = await _context.CandidateDetail
                .FirstOrDefaultAsync(m => m.candidate_id == id);
            if (candidateDetail == null)
            {
                return NotFound();
            }

            return View(candidateDetail);
        }

        // POST: CandidateDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var candidateDetail = await _context.CandidateDetail.FindAsync(id);
            _context.CandidateDetail.Remove(candidateDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandidateDetailExists(string id)
        {
            return _context.CandidateDetail.Any(e => e.candidate_id == id);
        }
    }
}
