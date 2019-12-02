using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IPGManagement.Models;



namespace IPGManagement.Controllers
{
    [Authorize(Policy = "CanManageFuncionarios")]
    //[Authorize(Roles = "manager,admin")]
    public class FuncionariosController : Controller
    {
       
        private readonly IPGManagementDbContext _context;

            public FuncionariosController(IPGManagementDbContext context)
            {
                _context = context;
            }

            // GET: Funcionarios
            public async Task<IActionResult> Index()
            {
                return View(await _context.Funcionario.ToListAsync());
            }

            // GET: Funcionario/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var funcionario = await _context.Funcionario
                    .FirstOrDefaultAsync(m => m.IdFuncionario == id);
                if (funcionario == null)
                {
                    return NotFound();
                }

                return View(funcionario);
            }

            // GET: Funcionario/Create        
            public IActionResult Create()
            {
                return View();
            }

            // POST: Funcionarios/Create
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("IdFuncionario, Nome, DataNascimento, Sexo")] Funcionario funcionario)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(funcionario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(funcionario);
            }

            // GET: Funcioanrios/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var funcionario = await _context.Funcionario.FindAsync(id);
                if (funcionario == null)
                {
                    return NotFound();
                }
                return View(funcionario);
            }

            // POST: Funcionarios/Edit/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("IdFuncionario, Nome, DataNascimento, Sexo")] Funcionario funcionario)
            {
                if (id != funcionario.IdFuncionario)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(funcionario);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!FuncionarioExists(funcionario.IdFuncionario))
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
                return View(funcionario);
            }

            // GET: Funcionarios/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var funcionario = await _context.Funcionario
                    .FirstOrDefaultAsync(m => m.IdFuncionarios == id);
                if (funcionario == null)
                {
                    return NotFound();
                }

                return View(funcionario);
            }

            // POST: Funcionarios/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var funcionario = await _context.Funcionario.FindAsync(id);
                _context.Funcionario.Remove(funcionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool FuncionarioExists(int id)
            {
                return _context.Funcionario.Any(e => e.IdFuncionarios == id);
            }
        }
}
