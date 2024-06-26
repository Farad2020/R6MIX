﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using R6MIX.Data;
using R6MIX.Models;

namespace R6MIX.Controllers
{
    public class OperatorsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OperatorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Operators
        public async Task<IActionResult> Index()
        {
            return View(await _context.Operator.ToListAsync());
        }

        // GET: Operators/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @operator = await _context.Operator.Include(m => m.OpSide).Include(m => m.OpLoadout)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@operator == null)
            {
                return NotFound();
            }

            return View(@operator);
        }

        [Authorize]
        // GET: Operators/Create
        public async Task<IActionResult> Create()
        {

            ViewBag.Sides = await _context.Side.ToListAsync();
            ViewBag.Loadouts = await _context.Loadout.ToListAsync();
            return View();
        }

        // POST: Operators/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int OpLoadoutId, int OpSideId, [Bind("Id,Name,OpImgLink,OpIconLink,Role,Origin,Biography,PshycoPortrait,Armor,Speed,Difficulty,AbilityName,AbilityIcon,AbilityTLDR,AbilityDemoLink")] Operator @operator)
        {
            if (ModelState.IsValid)
            {
                @operator.OpLoadout = _context.Loadout.FirstOrDefault(m => m.Id == OpLoadoutId);
                @operator.OpSide = _context.Side.FirstOrDefault(m => m.Id == OpSideId);

                _context.Add(@operator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@operator);
        }

        // GET: Operators/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @operator = await _context.Operator.Include(m => m.OpSide).Include(m => m.OpLoadout)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@operator == null)
            {
                return NotFound();
            }

            ViewBag.Sides = await _context.Side.ToListAsync();
            ViewBag.OriginalSide = @operator.OpSide;
            ViewBag.Loadouts = await _context.Loadout.ToListAsync();
            ViewBag.OriginalLoadout = @operator.OpLoadout;

            return View(@operator);
        }

        // POST: Operators/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, int OpLoadoutId, int OpSideId, [Bind("Id,Name,OpImgLink,OpIconLink,Role,Origin,Biography,PshycoPortrait,Armor,Speed,Difficulty,AbilityName,AbilityIcon,AbilityTLDR,AbilityDemoLink")] Operator @operator)
        {
            if (id != @operator.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    @operator.OpLoadout = _context.Loadout.FirstOrDefault(m => m.Id == OpLoadoutId);
                    @operator.OpSide = _context.Side.FirstOrDefault(m => m.Id == OpSideId);

                    _context.Update(@operator);

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OperatorExists(@operator.Id))
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
            return View(@operator);
        }

        // GET: Operators/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @operator = await _context.Operator
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@operator == null)
            {
                return NotFound();
            }

            return View(@operator);
        }

        // POST: Operators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @operator = await _context.Operator.FindAsync(id);
            _context.Operator.Remove(@operator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OperatorExists(int id)
        {
            return _context.Operator.Any(e => e.Id == id);
        }
    }
}
