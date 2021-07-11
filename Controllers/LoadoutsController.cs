using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using R6MIX.Data;
using R6MIX.Models;

namespace R6MIX.Controllers
{
    public class LoadoutsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoadoutsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Loadouts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Loadout.ToListAsync());
        }

        // GET: Loadouts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loadout = await _context.Loadout
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loadout == null)
            {
                return NotFound();
            }

            return View(loadout);
        }

        // GET: Loadouts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Loadouts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PrimaryWeapon,PrimaryWeaponImg,SecondaryWeapon,SecondaryWeaponImg,Gadget,GadgetImg")] Loadout loadout)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loadout);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loadout);
        }

        // GET: Loadouts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loadout = await _context.Loadout.FindAsync(id);
            if (loadout == null)
            {
                return NotFound();
            }
            return View(loadout);
        }

        // POST: Loadouts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PrimaryWeapon,PrimaryWeaponImg,SecondaryWeapon,SecondaryWeaponImg,Gadget,GadgetImg")] Loadout loadout)
        {
            if (id != loadout.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loadout);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoadoutExists(loadout.Id))
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
            return View(loadout);
        }

        // GET: Loadouts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loadout = await _context.Loadout
                .FirstOrDefaultAsync(m => m.Id == id);
            if (loadout == null)
            {
                return NotFound();
            }

            return View(loadout);
        }

        // POST: Loadouts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loadout = await _context.Loadout.FindAsync(id);
            _context.Loadout.Remove(loadout);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoadoutExists(int id)
        {
            return _context.Loadout.Any(e => e.Id == id);
        }
    }
}
