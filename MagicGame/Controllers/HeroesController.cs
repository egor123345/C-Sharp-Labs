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
    public class HeroesController : Controller
    {
        private readonly GameContext _context;

        public HeroesController(GameContext context)
        {
            _context = context;
        }

        // GET: Heroes
        public async Task<IActionResult> Index(int? pageNumber)
        {
           
            var gameContext = _context.Heroes.Include(h => h.Player).Include(h => h.Items);

            int pageSize = 6;
            return View(await PaginatedList<Hero>.CreateAsync(gameContext.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Heroes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Heroes
                .Include(h => h.Player).Include(h => h.Items)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // GET: Heroes/Create
        public IActionResult Create()
        {
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id");
            ViewData["Items"] = new SelectList(_context.Items, "Id", "Id");

            return View();
        }

        // POST: Heroes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Race,Level,Health,Kda,GamesCount,PlayerId")] Hero hero)
        {
            if (ModelState.IsValid)
            {
                var heroItemsId = Request.Form.FirstOrDefault(p => p.Key == "Items").Value;
                IEnumerable<Item> heroItems = _context.Items.Where(i => heroItemsId.Contains(i.Id.ToString()));
                hero.Items = new List<Item>();
                foreach (Item i in heroItems)
                {
                    hero.Items.Add(i);
                }
                _context.Add(hero);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }
            
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", hero.PlayerId);
            ViewData["Items"] = new SelectList(_context.Items, "Id", "Id", hero.Items);

            return View(hero);
        }

        // GET: Heroes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

           // _context.Heroes.Include(i => i.Items);
          //  var hero = await _context.Heroes.FindAsync(id);

                var hero = await _context.Heroes
            .Include(h => h.Player).Include(h => h.Items)
            .FirstOrDefaultAsync(m => m.Id == id);

            if (hero == null)
            {
                return NotFound();
            }
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", hero.PlayerId);

         
            var avItems = _context.Items.AsEnumerable().Except(hero.Items.AsEnumerable());
            ViewData["AvailableItems"] = new SelectList(avItems, "Id", "Id");

            ViewData["HeroItems"] = new SelectList(hero.Items, "Id", "Id");



            return View(hero);
        }

        // POST: Heroes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Race,Level,Health,Kda,GamesCount,PlayerId")] Hero hero)
        {
            if (id != hero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    _context.Update(hero);
                    
                    await _context.SaveChangesAsync();

                    var heroItemsId = Request.Form.FirstOrDefault(p => p.Key == "Items").Value;
                    IEnumerable<Item> respItems = _context.Items.Where(i => heroItemsId.Contains(i.Id.ToString()));
                    
                     hero.Items  = _context.Heroes.Include(i => i.Items).FirstOrDefault(h => h.Id == hero.Id).Items;
                    

                    foreach (Item i in respItems)
                    {
                        if (hero.Items.Contains(i))
                        {
                            hero.Items.Remove(i);
                            continue;
                        }
                        hero.Items.Add(i);
                    }
                    
                    
                    _context.Update(hero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HeroExists(hero.Id))
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
            ViewData["PlayerId"] = new SelectList(_context.Players, "Id", "Id", hero.PlayerId);
            return View(hero);
        }

        // GET: Heroes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hero = await _context.Heroes
                .Include(h => h.Player).Include(h => h.Items)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hero == null)
            {
                return NotFound();
            }

            return View(hero);
        }

        // POST: Heroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //   var hero = await _context.Heroes.FindAsync(id);
            var hero = await _context.Heroes
               .Include(h => h.Player).Include(h => h.Items)
               .FirstOrDefaultAsync(m => m.Id == id);
            _context.Heroes.Remove(hero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HeroExists(int id)
        {
            return _context.Heroes.Any(e => e.Id == id);
        }
    }
}
