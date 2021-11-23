using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MagicGame.Models;

namespace MagicGame.Controllers
{
    public class PlayersController : Controller
    {
        private readonly GameContext _context;

        public PlayersController(GameContext context)
        {
            _context = context;
        }

        // GET: Players
        public async Task<IActionResult> Index(string sortOrder, string currentFilter,  string searchString, int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;

            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["LoginSortParm"] = sortOrder == "Login" ? "login_desc" : "Login";
            ViewData["RegDateSortParm"] = sortOrder == "RegDate" ? "reg_date_desk" : "RegDate";

            var players = _context.Players.Select(p => p);

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;


            if (!String.IsNullOrEmpty(searchString))
            {
                players = players.Where(p => p.Login.Contains(searchString) || p.Name.Contains(searchString));
            }

         

            switch (sortOrder)
            {
                case "name_desc":
                    players = players.OrderByDescending(p => p.Name);
                    break;
                case "date_desc":
                    players = players.OrderByDescending(p => p.Birthday);
                    break;
                case "Date":
                    players = players.OrderBy(p => p.Birthday);
                    break;
                case "Login":
                    players = players.OrderBy(p => p.Login);
                    break;
                case "login_desc":
                    players = players.OrderByDescending(p => p.Login);
                    break;
                case "RegDate":
                    players = players.OrderBy(p => p.RegistrationDate);
                    break;
                case "reg_date_desk":
                    players = players.OrderByDescending(p => p.RegistrationDate);
                    break;
                default:
                    players = players.OrderBy(p => p.Name);
                    break;
            }

            int pageSize = 4;
            return View(await PaginatedList<Player>.CreateAsync(players.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        

        // GET: Players/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Players.Include(p => p.heroes)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // GET: Players/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Players/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Birthday,Login,RegistrationDate")] Player player)
        {
            if (ModelState.IsValid)
            {
                _context.Add(player);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(player);
        }

        // GET: Players/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            return View(player);
        }

        // POST: Players/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Birthday,Login,RegistrationDate")] Player player)
        {
            if (id != player.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(player);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlayerExists(player.Id))
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
            return View(player);
        }

        // GET: Players/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var player = await _context.Players
                .FirstOrDefaultAsync(m => m.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        // POST: Players/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var player = await _context.Players.FindAsync(id);
            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.Id == id);
        }
    }
}
